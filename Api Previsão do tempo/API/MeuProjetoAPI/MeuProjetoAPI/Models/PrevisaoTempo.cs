using Newtonsoft.Json;
using System.Numerics;

namespace MeuProjetoAPI.Models
{
    public class PrevisaoTempo
    {
        [JsonProperty("weather")]
        public List<Descricao> Descricao { get; set; }

        [JsonProperty("main")]
        public Tempo Tempo { get; set; }

        [JsonProperty("visibility")]
        public double Visibilidade { get; set; }

        [JsonProperty("wind")]
        public Vento Vento { get; set; }

        [JsonProperty("clouds")]
        public Nuvem Nuvem { get; set; }

        public DateTime DataHora => DateTime.Now;

        [JsonProperty("sys")]
        public Sol Sol { get; set; }

        [JsonProperty("timezone")]
        public double FusoHorario { get; set; }
    }
    public class Descricao
    {
        [JsonProperty("description")]
        public string DescricaoCeu { get; set; }
    }

    public class Tempo
    {
        [JsonProperty("temp")]
        public double TemperaturaAtual { get; set; }
     

        [JsonProperty("feels_like")]
        public double SensacaoTermica { get; set; }

        [JsonProperty("temp_min")]
        public double TemperaturaMinima { get; set; }

        [JsonProperty("temp_max")]
        public double TemperaturaMaxima { get; set; }

        [JsonProperty("pressure")]
        public string Pressao { get; set; }

        [JsonProperty("humidity")]
        public string Humidade { get; set; }        
    }

    public class Vento
    {
        [JsonProperty("temp")]
        public double Velocidade { get; set; }

        [JsonProperty("deg")]
        public double Graus { get; set; }
    }

    public class Sol
    {
        [JsonProperty("sunrise")]
        public long NascerDoSolLong { get; set; }

        public DateTime NascerDoSol => DateTimeOffset.FromUnixTimeSeconds(NascerDoSolLong).DateTime.AddHours(-3);

        [JsonProperty("sunset")]
        public long PorDoSolLong { get; set; }

        public DateTime PorDoSol => DateTimeOffset.FromUnixTimeSeconds(PorDoSolLong).DateTime.AddHours(-3);
    }

    public class Nuvem
    {
        [JsonProperty("all")]
        public int Quantidade { get; set; }
    }
}