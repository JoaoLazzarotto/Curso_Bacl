using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MeuProjetoAPI.Models.ViewModels;
using System.Reflection.Metadata;
using MeuProjetoAPI.Models.Commands;
using System.Globalization;
using MeuProjetoAPI.Models;
using MeuProjetoApi.Models;
using MeuProjetoApi.BancoDados.Repositorios;

namespace MeuProjetoAPI.Controllers
{
    [ApiController]
    public class WeatherController : ControllerBase
    {
        //public PrevisaoTempoRepositorio Repositorio = new PrevisaoTempoRepositorio();


        [HttpPost]
        [Route("previsao/tempo")]       
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterPrevisaoTempo([FromBody] ObterPrevisaoTempoCommand command)
        {
            try
           {
                if(command == null)
                {
                    return BadRequest("Erro na requisição");
                }

                CidadeViewModel cidadeVm = ObterLatLonDeCidade(command.NomeCidade);

                if (cidadeVm == null || string.IsNullOrEmpty(cidadeVm.Latitude) || string.IsNullOrEmpty(cidadeVm.Longitude))
                {
                    return BadRequest("Cidade não encontrada");
                }

                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?lat={cidadeVm.Latitude}&lon={cidadeVm.Longitude}&appid=53a2605b15e70ad44d745b2184feef9a&lang=pt_br";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        PrevisaoTempoViewModel previsaoTempo = JsonConvert.DeserializeObject<PrevisaoTempoViewModel>(json, settings);

                        var novaPrevisao = new PrevisaoTempo()
                        {
                            IdUsuario = command.IdUsuario.Value,
                            NomeCidade = cidadeVm.InfoCidade.Cidade,
                            NomePais = cidadeVm.InfoCidade.Pais,
                            DescricaoCeu = previsaoTempo.Descricao.FirstOrDefault()?.DescricaoCeu,
                            SensacaoTermicaCelsius = previsaoTempo.Tempo.SensacaoTermicaCelsius,
                            Pressao = previsaoTempo.Tempo.Pressao,
                            Humidade = previsaoTempo.Tempo.Humidade,
                            NascerDoSol = previsaoTempo.Sol.NascerDoSol,
                            PorDoSol = previsaoTempo.Sol.PorDoSol,
                            TemperaturaAtualCelsius = previsaoTempo.Tempo.TemperaturaAtualCelsius,
                            TemperaturaMinimaCelsius = previsaoTempo.Tempo.TemperaturaMinimaCelsius,
                            TemperaturaMaximaCelsius = previsaoTempo.Tempo.TemperaturaMaximaCelsius,
                            VelocidadeKMH = previsaoTempo.Vento.VelocidadeKMH,
                            Graus = previsaoTempo.Vento.Graus,
                            Quantidade = previsaoTempo.Nuvem.Quantidade,
                            VisibilidadeKm = previsaoTempo.VisibilidadeKm,
                            DataHora = previsaoTempo.DataHora,
                            FusoHorario = previsaoTempo.FusoHorario,
                        };

                        //Repositorio.Adicionar(novaPrevisao);


                        return Ok(novaPrevisao);
                    }
                    
                    
                }
                return BadRequest("Erro");
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro na requisição: " + ex.Message);
            }
        }

        private CidadeViewModel ObterLatLonDeCidade(string cidadeNome)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string url = $"https://geocode.xyz/%7B{cidadeNome}%7D?json=1";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var resultadoJson = response.Content.ReadAsStringAsync().Result;
                        var cidadeResultado = JsonConvert.DeserializeObject<CidadeViewModel>(resultadoJson);

                        return cidadeResultado;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro na requisição: " + ex.Message);
            }
            return null;
        }

    }
}
