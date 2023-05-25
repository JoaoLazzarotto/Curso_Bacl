namespace Capitulo12.Exercicio32
{
    internal class Program
    {
        /*
         32. Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e mostre-os na ordem lida. Em
             seguida, mostre-os em ordem crescente e decrescente. 
         */
        static void Main(string[] args)
        {
            int[][] grupos = new int[5][];

            // Leitura dos grupos de valores
            for (int i = 0; i < 5; i++)
            {
                grupos[i] = new int[4];
                Console.WriteLine($"Digite os valores do grupo {i + 1}:");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Valor {j + 1}: ");
                    grupos[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Mostrando os grupos na ordem lida
            Console.WriteLine("Grupos na ordem lida:");
            foreach (var grupo in grupos)
            {
                foreach (var valor in grupo)
                {
                    Console.Write(valor + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrando os grupos em ordem crescente
            Console.WriteLine("Grupos em ordem crescente:");
            foreach (var grupo in grupos)
            {
                Array.Sort(grupo);
                foreach (var valor in grupo)
                {
                    Console.Write(valor + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrando os grupos em ordem decrescente
            Console.WriteLine("Grupos em ordem decrescente:");
            foreach (var grupo in grupos)
            {
                Array.Sort(grupo);
                Array.Reverse(grupo);
                foreach (var valor in grupo)
                {
                    Console.Write(valor + " ");
                }
            }
        }
    }
}