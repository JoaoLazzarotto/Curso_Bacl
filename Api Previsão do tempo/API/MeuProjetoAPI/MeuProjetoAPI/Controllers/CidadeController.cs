using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MeuProjetoAPI.Models.ViewModels;
using MeuProjetoAPI.Models;
using System.Reflection;

namespace MeuProjetoAPI.Controllers
{
    [ApiController]
    
    public class CidadeController : ControllerBase
    {
        [HttpGet]
        [Route("cidade/obter")]
        public IEnumerable<BuscarCidadeViewModel> Get()
        {
           
            var jsonFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot\\city.list.json");

          
            var json = System.IO.File.ReadAllText(jsonFilePath);

          
            List<BuscarCidadeViewModel> listaCidades = JsonConvert.DeserializeObject<List<BuscarCidadeViewModel>>(json);

           
            return listaCidades;
        }
    }
}
