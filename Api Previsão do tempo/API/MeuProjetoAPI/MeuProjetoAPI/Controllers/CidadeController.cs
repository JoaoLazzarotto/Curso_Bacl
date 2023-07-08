using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MeuProjetoAPI.Models.ViewModels;
using MeuProjetoAPI.Models;

namespace MeuProjetoAPI.Controllers
{
  
    public class CidadeController : ControllerBase
    {
        [HttpGet]
        public IActionResult CidadesExenplos(listaCidades)
        {
            var json = File.ReadAllText("C:/MeuProjetoAPI/city.list.json");

            var listaCidades = JsonConvert.DeserializeObject<List<BuscarCidadeViewModel>>(json);        
            return (IActionResult)listaCidades;
        }

    }
}
