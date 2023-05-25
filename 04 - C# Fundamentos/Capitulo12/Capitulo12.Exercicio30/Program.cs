namespace Capitulo12.Exercicio30
{
    internal class Program
    {
        /*
          30. Faça um programa que leia um valor n. inteiro e positivo, calcule e mostre a seguinte soma:
                
                S = 1 + 1/2 + 1/3 + ¼ + ... + 1/n
         */
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro e positivo: ");
            int n = int.Parse(Console.ReadLine());

            double soma = 0;

            for (int i = 1; i <= n; i++)
            {
                soma += 1.0 / i;
            }

            Console.WriteLine("A soma é: " + soma);
        }
    }
}