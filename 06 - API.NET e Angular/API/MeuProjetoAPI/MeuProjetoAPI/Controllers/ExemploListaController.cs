using MeuProjetoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Net;

namespace MeuProjetoAPI.Controllers
{
    /*[ApiController]
    public class ExemploListaController : ControllerBase
    {/*
        public static List<Pessoa> ListaPessoas = new List<Pessoa>()
        {
            new Pessoa() { Id = 1, Nome = "Zé", Cpf = "000.000.000-00", Email = "ze@gmail.com", Telefone = "(47) 99874-5632" },
            new Pessoa() { Id = 2, Nome = "João", Cpf = "111.111.000-00", Email = "joao@gmail.com", Telefone = "(47) 99974-5632" },
            new Pessoa() { Id = 3, Nome = "Maria", Cpf = "222.222.000-00", Email = "maria@gmail.com", Telefone = "(47) 98884-9999" },
        };
        private object _dbContext;

        [HttpGet]
        [Route("pessoa/obterTodos")]
        [ProducesResponseType(typeof(List<Pessoa>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterTodos()
        {
            try
            {


                return Ok(ListaPessoas);

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }


        [HttpGet]
        [Route("pessoa/obterPorId/{id}")]
        [ProducesResponseType(typeof(List<Pessoa>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var pessoa = ListaPessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                if (pessoa == null)
                {
                    return NotFound();

                }
                else
                {
                    return Ok(pessoa);
                }


            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }


        [HttpPost]
        [Route("pessoa/adicionar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Adicionar([FromBody] Pessoa pessoa)
        {
            try
            {
                if (pessoa == null)
                {
                    return BadRequest("Não foi possível obter a pessoa");
                }

                ListaPessoas.Add(pessoa);

                return Created("", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }

        }



        [HttpPut]
        [Route("pessoa/atualizar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Atualizar([FromBody] Pessoa pessoa)
        {
            try
            {
                Pessoa pessoaAtualizar = ListaPessoas
                    .Where(p => p.Id == pessoa.Id)
                    .FirstOrDefault();

                if (pessoaAtualizar == null)
                {
                    return NoContent();
                }
                else
                {

                    pessoaAtualizar.Nome = pessoa.Nome;
                    pessoaAtualizar.Cpf = pessoa.Cpf;
                    pessoaAtualizar.Email = pessoa.Email;
                    pessoaAtualizar.Telefone = pessoa.Telefone;

                    return Ok(pessoaAtualizar);

                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }



        }

        [HttpDelete]
        [Route("pessoa/excluir/{id}")]
        [ProducesResponseType(typeof(Nullable), (int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Excluir(int id)
        {
            try
            {
                var pessoa = ListaPessoas
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

                if (pessoa == null)
                {
                    return NotFound("Pessoa não encontrada");
                }

                ListaPessoas.Remove(pessoa);

                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }

        }
    }*/
}