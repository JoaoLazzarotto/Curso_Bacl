using Newtonsoft.Json;

namespace MeuProjetoAPI.Models.ViewModels

{

    //[{"id":5090,"name":"Blumenau","state":"SC","country":"BR  "}]
    public class CidadeViewModel
    {        

        [JsonProperty("standard")]
        public InfoCidade InfoCidade { get; set; }

        [JsonProperty("longt")]
        public string Longitude { get; set; }

        [JsonProperty("latt")]
        public string Latitude { get; set; }
    }

    public class InfoCidade
    {
        [JsonProperty("city")]
        public string Cidade { get; set; }

        [JsonProperty("prov")]
        public string AbreviacaoPais { get; set; }

        [JsonProperty("countryname")]
        public string Pais { get; set; }

    }
}
