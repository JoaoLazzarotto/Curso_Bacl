using MeuProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
         public static List<Pessoa> Pessoas = new List<Pessoa>()
         {
            new Pessoa() { Id = 1, Nome = "Zé", Cpf = "000.000.000-00", Email = "ze@email.com"},
            new Pessoa() { Id = 2, Nome = "João", Cpf = "111.222.333-00", Email = "joao@email.com"},
            new Pessoa() { Id = 3, Nome = "Maria", Cpf = "444.555.666-00", Email = "maria@email.com"}
         };

    

        // Método chamado ao carregar a pagina pessoa/listagem
        public IActionResult Listagem()
        {
            return View(Pessoas);
        }

        // Método chamado ao carregar a pagina pessoa/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // Método chamado ao carregar a pagina pessoa/Edição/Id
        public IActionResult Edicao(int id)
        {
            
            var pessoa = Pessoas.Where(p => p.Id == id).FirstOrDefault();
            return View(pessoa);
        }

        public IActionResult Adicionar(Pessoa pessoa)
        {

            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                // adicionar a pessoa na lista
                Pessoas.Add(pessoa);
                return RedirectToAction("Listagem");
            }
            else
            {
                // quando ha algum erro de validação
                return View("Cadastro", pessoa);
            }
        }

        public ActionResult Editar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                Pessoas.RemoveAll(p => p.Id == pessoa.Id);
                Pessoas.Add(pessoa);

                return RedirectToAction("Listagem");
            }
            return View("Edicao", pessoa);
        }

    }
}
