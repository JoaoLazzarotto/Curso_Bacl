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
    public class ConversaoController : ControllerBase
    {
        
        [HttpPost]
        public Tempo ConverterKelvinParaCelsius(Tempo model)
        {
            model.TemperaturaAtual = model.TemperaturaAtual - 273.15;
            model.SensacaoTermica = model.SensacaoTermica - 273.15;
            model.TemperaturaMinima = model.TemperaturaMinima - 273.15;
            model.TemperaturaMaxima = model.TemperaturaMaxima - 273.15;
            return model;
        }
        [HttpPost]
        public PrevisaoTempo ConverterKelvinParaCelsius(PrevisaoTempo model)
        {
            model.Visibilidade = model.Visibilidade / 100;         
            return model;
        }
        [HttpPost]
        public Vento ConverterVelocidadeVento(Vento model)
        {
            model.Velocidade = model.Velocidade * 3.6;
            return model;
        }
    }
       
}
