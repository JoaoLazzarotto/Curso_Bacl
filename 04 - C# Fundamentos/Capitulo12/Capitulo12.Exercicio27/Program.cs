namespace Capitulo12.Exercicio27
{
    internal class Program
    {
        /*
         27. Um restaurante esta fazendo uma promoção semanal de descontos para clientes de acordo com as iniciar
             do nome da pessoa. Criar um algoritmo que leia o primeiro nome do cliente, o valor de sua conta e se o nome
             iniciar com as letras A, D, M ou S, dar um desconto de 30%. Para o cliente cujo nome não se inicia por
             nenhuma dessas letras, exibir a mensagem “Que pena. Nesta semana o desconto não é para seu nome; mas
             continue nos prestigiando que sua vez chegara”.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu primeiro nome!!!");
            string nome = Console.ReadLine();
            var primeiraLetra = nome.Substring(0, 1).ToUpper();



           // var primeiraLetra = char.ToUpper(nome[0]) + nome.Substring(0);




            Console.WriteLine(primeiraLetra);    
        }
    }
}