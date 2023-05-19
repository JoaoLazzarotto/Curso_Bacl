namespace Capitulo12.Exercicio23
{
    internal class Program
    {
        /*
         23. Efetuar a leitura de cinco números inteiros diferentes e identificar o maior e o menor valor.
         */
        static void Main(string[] args)
        {

            int maior = int.MinValue;
            int menor = int.MaxValue;

            for (int contador = 1; contador <= 5; contador++)
            {
                Console.Write($"Digite o {contador}º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}








