using ExercicioExtra.BancoDeDados.Context;
using ExercicioExtra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra.BancoDeDados.Repositorio
{
    public class ProdutoRepositorio
    {
        public Produto Adicionar(Produto produto)
        {
            using (var bancoDados = new MeuContext())
            {
                bancoDados.Produtos.Add(produto);
                bancoDados.SaveChanges();
            }

            return produto;
        }

        public Produto Atualizar(Produto produto)
        {
            using (var bancoDados = new MeuContext())
            {
                bancoDados.Produtos.Update(produto);
                bancoDados.SaveChanges();
            }

            return produto;
        }

        public void Excluir(int id)
        {
            using (var bancoDados = new MeuContext())
            {
                var produto = bancoDados.Produtos
                    .Where(produto => produto.Id == id)
                    .FirstOrDefault();
                if (produto != null)
                {
                    bancoDados.Remove(produto);
                    bancoDados.SaveChanges();
                }

            }


        }
        public Produto ObterporId(int id)
        {
            using (var bancoDados = new MeuContext())
            {
                var produto = bancoDados.Produtos
                    .Where(produto => produto.Id == id)
                    .FirstOrDefault();

                return produto;

            }
        }

        public List<Produto> ObterTodos()
        {
            using (var bancoDados = new MeuContext())
            {
                var produto = bancoDados.Produtos.ToList();
                return produto;

            }
        }
    }

}


