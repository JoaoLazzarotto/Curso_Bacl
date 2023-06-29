using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MeuProjetoAPI.Models
{
    public class PrevisaoTempo
    {
        [JsonProperty("coord")]
        public Coordenadas Coordenadas { get; set; }

        [JsonProperty("weather")]
        public List<Clima> Clima { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Principal Principal { get; set; }

        [JsonProperty("visibility")]
        public int Visibilidade { get; set; }

        [JsonProperty("wind")]
        public Vento Vento { get; set; }

        [JsonProperty("clouds")]
        public Nuvens Nuvens { get; set; }

        [JsonProperty("dt")]
        public long DataHora { get; set; }

        [JsonProperty("sys")]
        public Sistema Sistema { get; set; }

        [JsonProperty("timezone")]
        public int FusoHorario { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Cidade { get; set; }

        [JsonProperty("cod")]
        public int Codigo { get; set; }
    }

    public class Coordenadas
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }

    public class Clima
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Principal { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("icon")]
        public string Icone { get; set; }
    }

    public class Principal
    {
        [JsonProperty("temp")]
        public double Temperatura { get; set; }

        [JsonProperty("feels_like")]
        public double SensacaoTermica { get; set; }

        [JsonProperty("temp_min")]
        public double TemperaturaMinima { get; set; }

        [JsonProperty("temp_max")]
        public double TemperaturaMaxima { get; set; }

        [JsonProperty("pressure")]
        public int Pressao { get; set; }

        [JsonProperty("humidity")]
        public int Umidade { get; set; }
    }

    public class Vento
    {
        [JsonProperty("speed")]
        public double Velocidade { get; set; }

        [JsonProperty("deg")]
        public int Graus { get; set; }

        [JsonProperty("gust")]
        public double Rajada { get; set; }
    }

    public class Nuvens
    {
        [JsonProperty("all")]
        public int Cobertura { get; set; }
    }

    public class Sistema
    {
        [JsonProperty("type")]
        public int Tipo { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("sunrise")]
        public long NascerDoSol { get; set; }

        [JsonProperty("sunset")]
        public long PorDoSol { get; set; }
    }
}
