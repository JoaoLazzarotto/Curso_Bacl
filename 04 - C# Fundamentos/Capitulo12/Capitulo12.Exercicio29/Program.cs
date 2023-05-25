namespace Capitulo12.Exercicio29
{
    internal class Program
    {
        /*
         29. Faça um programa que verifique e mostre os números entre 1.000 e 2.000 (inclusive) que, quando
             divididos por 11 produzam resto igual a 5.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Números entre 1.000 e 2.000 que divididos por 11 têm resto igual a 5:");

            for (int i = 1000; i <= 2000; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
 }