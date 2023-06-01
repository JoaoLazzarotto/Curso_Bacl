using ExercicioExtra.BancoDeDados.Context;
using ExercicioExtra.BancoDeDados.Repositorio;
using ExercicioExtra.Modelos;

namespace ExercicioExtra1
{
    /*
    Exercício 1 de Programação em C#: Entity Framework Core e CRUD:

    Crie um projeto ConsoleApplication e implemente os seguintes requisitos:

    a) Crie uma entidade/classe chamada 'Produto' que contenha as seguintes propriedades:

        - int Id
        - string Nome
        - DateTime? DataValidade
        - decimal? PrecoCompra
        - decimal PrecoVenda
        - decimal QuantidadeEstoque;

    b) Adicione os pacotes do nuget para trabalhar com o Entity Framework Core (disponíveis no github da turma);
    c) Crie uma classe de contexto herdando de 'DbContext' para usar o Entity Framework Core (a classe que contém as definições da conexão e a importação das configs);
    d) O nome do banco de dados será 'ExercicioExtra1';
    e) Crie uma config para o Produto de acordo com as seguintes regras:

        - O Id deve ser a chave a tabela, usando IdentityColumn;
        - O Nome deve ser obrigatório e ter no máximo 200 caracteres;
        - A data de validade é opcional
        - O preço de compra é opcional
        - O preço de venda é obrigatório
        - A QuantidadeEstoque é obrigatória;
    
    f) Crie uma Migration usando o comando 'Add-Migration' e escolha um nome para ela;
    g) Verifique a migração criada e caso esteja ok, aplique ela no banco de dados com 'Update-Database';
    h) Crie uma classe de repositório contendo as operações de CRUD para o Produto (Adicionar, Atualizar, Obter e Excluir);
    i) No método Main da classe Program, instancie o repositório e execute as operações do CRUD para validar se as manipulações no banco ocorrem conforme esperado; 

     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira qual será o função do banco de dados de Produtos. Ex: Adicionar, Atualizar, Obter todos, Obter por Id ou Excluir. ")
                 
            var repositorioProduto = new ProdutoRepositorio();


            // Adicionando
            Produto novoproduto = new Produto();
            novoproduto.Nome = "Sal";
            novoproduto.DataValidade = new DateTime(2024, 05, 14);
            novoproduto.PrecoCompra = 6;
            novoproduto.PrecoVenda = 15;
            novoproduto.QuantidadeEstoque = 27;
            repositorioProduto.Adicionar(novoproduto);


            // Atualizando (lembre-se que é necessário passar o id ao atualizar)
            Console.WriteLine("Para atualizar insira o Id!");
            int id = int.Parse(Console.ReadLine());

            Produto produto2 = new Produto();
            produto2.Nome = "";
            produto2.DataValidade = "";
            produto2.PrecoCompra = ;
            produto2.PrecoVenda = ;
            produto1.QuantidadeEstoque = ;
            repositorioProduto.Atualizar(produto2);


            // obtendo todos
            var listaProdutos = repositorioProduto.ObterTodos();
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, Data de Validade: {produto.DataValidade}, Preco de Compra: {produto.PrecoCompra}, Preco de Venda: {produto.PrecoVenda}, Quantidade no Estoque: {produto.QuantidadeEstoque}");
            }

            // obtendo pelo id
            var produtoId1 = repositorioProduto.ObterPorId(1);
            Console.WriteLine($"Id: {produtoId1.Id}, Nome: {produtoId1.Nome}, Data de Validade: {produtoId1.DataValidade}, Preco de Compra: {produtoId1.PrecoCompra}, Preco de Venda: {produtoId1.PrecoVenda}, Quantidade no Estoque: {produtoId1.QuantidadeEstoque}");

            // deletando
            repositorioProduto.Deletar(1);
        }


    
      
    }
}

      