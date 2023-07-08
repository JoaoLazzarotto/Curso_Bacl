using Newtonsoft.Json;

namespace MeuProjetoAPI.Models.ViewModels
{
    public class BuscarCidadeViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("state")]
        public string Estado { get; set; }

        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("cord")]
        public Coordenadas Coordenadas { get; set; }

    }
    public class Coordenadas
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("cord")]
        public double Latitude { get; set; }
    }
}
