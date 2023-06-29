using MeuProjetoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public IActionResult Teste([FromForm] string cidade)
        {
            string apiKey = "53a2605b15e70ad44d745b2184feef9a";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        PrevisaoTempo previsaoTempo = JsonConvert.DeserializeObject<PrevisaoTempo>(json);
                        return Ok(previsaoTempo);
                      
                    }
                    else
                    {
                        Console.WriteLine("Erro ao obter a previsão do tempo.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro na requisição: " + ex.Message);
                }
            }
            return BadRequest();
        }
    }
}
public class WeatherData
{
    public string Name { get; set; }
    public MainData Main { get; set; }
    public Weather[] Weather { get; set; }
}

public class MainData
{
    public float Temp { get; set; }
    public int Humidity { get; set; }
}

public class Weather
{
    public string Description { get; set; }
}