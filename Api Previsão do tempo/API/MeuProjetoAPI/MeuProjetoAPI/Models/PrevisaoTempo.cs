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
        public double VisibilidadeMetro { get; set; }
        public double VisibilidadeKm => VisibilidadeMetro / 1000;

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
        public double TemperaturaAtualKelvin { get; set; }
        public double TemperaturaAtualCelsius => TemperaturaAtualKelvin - 273.15;


        [JsonProperty("feels_like")]
        public double SensacaoTermicaKelvin { get; set; }
        public double SensacaoTermicaCelsius => SensacaoTermicaKelvin - 273.15;

        [JsonProperty("temp_min")]
 
        public double TemperaturaMinimaKelvin { get; set; }
        public double TemperaturaMinimaCelsius => TemperaturaMinimaKelvin - 273.15;


        [JsonProperty("temp_max")]
        public double TemperaturaMaximaKelvin { get; set; }
        public double TemperaturaMaximaCelsius => TemperaturaMaximaKelvin - 273.15;

        [JsonProperty("pressure")]
        public string Pressao { get; set; }

        [JsonProperty("humidity")]
        public string Humidade { get; set; }        
    }

    public class Vento
    {
        [JsonProperty("temp")]
        public double VelocidadeMS { get; set; }
        public double VelocidadeKMH => VelocidadeMS * 3.6;

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