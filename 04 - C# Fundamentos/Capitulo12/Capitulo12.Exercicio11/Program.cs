namespace Capitulo12.Exercicio11
{
    internal class Program
    {
        /*
         11. Entrar com um número e imprimir uma das mensagens: maior do que 20, igual a 20 ou menor do que 20.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 20)
            {

                Console.WriteLine("Número inserido é maior que 20");
            }

            if (numero == 20)
            {

                Console.WriteLine("Número inserido é 20");
            }

            else if (numero < 20)
            { 

                Console.WriteLine("Número inserido é menor que 20");
            }

            Console.ReadKey();  
        }
    }
}