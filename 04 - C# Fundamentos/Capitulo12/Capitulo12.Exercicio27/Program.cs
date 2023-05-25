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
            Console.WriteLine("Qual foi o valor da conta?");
            double valorConta = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu nome!!!");
            string nome = Console.ReadLine();

            var primeiraLetra = nome.Substring(0, 1).ToUpper();

            double contaComDesconto = valorConta * 0.7;

          
            if (primeiraLetra == "A" || primeiraLetra == "D" || primeiraLetra == "M" || primeiraLetra == "S")
            {
                Console.WriteLine($"Parabéns você foi agraciado com um desconto de 30%, o valor da sua conta com desconto foi {contaComDesconto.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome, continue nos prestigiando que sua vez chegará");
            }
        }
    }
}