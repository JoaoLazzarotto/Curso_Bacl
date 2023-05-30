using MeuProjetoMVC.BancoDeDados.Repositorio;
using MeuProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {

        public PessoaRepositorio Repositorio = new PessoaRepositorio();
        // Método chamado ao carregar a pagina pessoa/listagem
        public IActionResult Listagem()
        {

            var pessoas = Repositorio.ObterTodos();
            return View(pessoas);
        }
      
        // Método chamado ao carregar a pagina pessoa/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // Método chamado ao carregar a pagina pessoa/Edição/Id
        public IActionResult Edicao(int id)
        {            
            var pessoa = Repositorio.ObterporId(id);
            return View(pessoa);
        }

        public IActionResult Adicionar(Pessoa pessoa)
        {

            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                // adicionar a pessoa na lista
                Repositorio.Adicionar(pessoa);
                return RedirectToAction("Listagem");
            }
            else
            {
                // quando ha algum erro de validação
                return View("Cadastro", pessoa);
            }
        }

        public IActionResult Editar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
               Repositorio.Atualizar(pessoa);

                return RedirectToAction("Listagem");
            }
            return View("Edicao", pessoa);
        }

        public IActionResult Excluir(int id)
        {

            Repositorio.Excluir(id);
            return RedirectToAction("Listagem");

        }


    }
}
