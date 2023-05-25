namespace Capitulo12.Exercicio31
{
    internal class Program
    {
        /*
         31. Faça um programa que mostre as tabuadas dos números de 1 a 10.
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i + ":");
                Console.WriteLine("--------------");

                for (int j = 1; j <= 10; j++)
                {
                    int resultado = i * j;
                    Console.WriteLine(i + " x " + j + " = " + resultado);
                }

               
            }
        }
    }
}