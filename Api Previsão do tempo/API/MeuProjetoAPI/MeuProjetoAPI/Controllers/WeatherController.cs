using MeuProjetoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MeuProjetoAPI.Models.ViewModels;
using System.Reflection.Metadata;

namespace MeuProjetoAPI.Controllers
{
    [ApiController]
    public class WeatherController : ControllerBase
    {       

        [HttpPost]
        [Route("weather/teste")]       
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Teste([FromForm] string cidadeNome)
        {
            try
            {
                CidadeViewModel cidadeVm = ObterLatLonDeCidade(cidadeNome);

                if (cidadeVm == null)
                {
                    return BadRequest("Cidade não encontrada");
                }

                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?lat={cidadeVm.Latitude}&lon={cidadeVm.Longitude}&appid=53a2605b15e70ad44d745b2184feef9a";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        PrevisaoTempo previsaoTempo = JsonConvert.DeserializeObject<PrevisaoTempo>(json, settings);
                        return Ok(previsaoTempo);
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
