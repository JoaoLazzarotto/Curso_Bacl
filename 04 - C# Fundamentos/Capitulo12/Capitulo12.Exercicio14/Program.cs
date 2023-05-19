namespace Capitulo12.Exercicio14
{
    internal class Program
    {
        /*
         14. Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se são iguais ou diferentes.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número!");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número!");
            float numero2 = float.Parse(Console.ReadLine());

            if (numero1 == numero2) 
            {
                Console.WriteLine("Os números são iguais");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Os números são diferentes");
                Console.ReadLine();

            }
        }
    }
}