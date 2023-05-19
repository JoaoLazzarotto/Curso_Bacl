namespace Capitulo12.Exercicio6
{
    internal class Program
    {
        /*
         6. Entrar com um número e imprimi-lo caso seja maior que 20.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número!");
            var numero = decimal.Parse(Console.ReadLine());

            if (numero > 20)
            {
                Console.WriteLine("O número é maior que 20");
            }

            else if(numero <= 20)
            {
                Console.WriteLine("O número é menor que 20");
            }


        




        }
    }
}