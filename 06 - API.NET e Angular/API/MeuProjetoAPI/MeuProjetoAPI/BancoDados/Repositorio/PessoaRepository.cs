using MeuProjetoAPI.BancoDados.Context;
using MeuProjetoAPI.Models;

namespace MeuProjetoAPI.BancoDados.Repositorio
{
    public class PessoaRepository
    {
        public Pessoa Adicionar(Pessoa pessoa)
        {
            using (var bancoDeDados = new MeuProjetoAPIContext())
            {
                bancoDeDados.TabelaPessoas.Add(pessoa);
                bancoDeDados.SaveChanges();
            }
            return pessoa;
        }
        public Pessoa Atualizar(Pessoa pessoa)
        {
            using (var bancoDeDados = new MeuProjetoAPIContext())
            {
                bancoDeDados.TabelaPessoas.Update(pessoa);
                bancoDeDados.SaveChanges();
            }
            return pessoa;
        }
        public void Excluir(int id)
        {
            using (var bancoDeDados = new MeuProjetoAPIContext())
            {
                var pessoa = bancoDeDados.TabelaPessoas
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

                if (pessoa != null)
                {
                    bancoDeDados.Remove(pessoa);
                    bancoDeDados.SaveChanges();
                }
            }
        }

        public Pessoa ObterPorId(int id)
        {
            using (var bancoDeDados = new MeuProjetoAPIContext())
            {
                var pessoa = bancoDeDados.TabelaPessoas
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

                return pessoa;
            }
        }

        public List<Pessoa> ObterTodos()
        {
            using (var bancoDeDados = new MeuProjetoAPIContext())
            {
                var listaPessoas = bancoDeDados.TabelaPessoas.ToList();
                return listaPessoas;
            }
        }
    }
}
