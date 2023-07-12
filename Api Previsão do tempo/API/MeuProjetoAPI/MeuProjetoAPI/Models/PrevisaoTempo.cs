using MeuProjetoApi.Models;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;

namespace MeuProjetoAPI.Models
{
    public class PrevisaoTempo
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataBusca { get; set; }

        public string NomeCidade { get; set; }
        public string NomePais { get; set; }
        public string DescricaoCeu { get; set; }
        public double? SensacaoTermicaCelsius { get; set; }
        public string Pressao { get; set; }
        public string Humidade { get; set; }
        public DateTime? NascerDoSol { get; set; }
        public DateTime? PorDoSol { get; set; }
        public double? TemperaturaAtualCelsius { get; set; }
        public double? TemperaturaMinimaCelsius { get; set; }
        public double? TemperaturaMaximaCelsius { get; set; }
        public double? VelocidadeKMH { get; set; }
        public double? Graus { get; set; }
        public int? Quantidade { get; set; }
        public double? VisibilidadeKm { get; set; }
        public DateTime? DataHora { get; set; }
        public double? FusoHorario { get; set; }
    }
}
