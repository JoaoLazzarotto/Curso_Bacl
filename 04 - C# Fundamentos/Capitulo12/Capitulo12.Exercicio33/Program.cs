namespace Capitulo12.Exercicio33
{
    internal class Program
    {
        /*
         33. Uma loja tem 15 clientes cadastrados e deseja enviar uma correspondência a cada um deles anunciando
             um bônus especial. Faça um programa que leia o nome do cliente e o valor das suas compras no ano passado.
             Calcule e mostre um bônus de 10% se o valor das compras for menor que R$1.000,00 e de 15% caso seja maior
             do que R$ 1.000,00.
         */
        static void Main(string[] args)
        {
            const int totalClientes = 15;
            const decimal limiteCompras = 1000.00m;
            const decimal bonusMenorQueLimite = 0.10m;
            const decimal bonusMaiorQueLimite = 0.15m;

            string[] nomes = new string[totalClientes];
            decimal[] valoresCompras = new decimal[totalClientes];

            // Leitura dos dados dos clientes
            for (int i = 0; i < totalClientes; i++)
            {
                Console.WriteLine($"Digite o nome do cliente {i + 1}:");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Digite o valor das compras de {nomes[i]} no ano passado:");
                valoresCompras[i] = decimal.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            // Cálculo e exibição dos bônus
            Console.WriteLine("Bônus dos clientes:");

            for (int i = 0; i < totalClientes; i++)
            {
                decimal bonus = 0;

                if (valoresCompras[i] < limiteCompras)
                {
                    bonus = valoresCompras[i] * bonusMenorQueLimite;
                }
                else
                {
                    bonus = valoresCompras[i] * bonusMaiorQueLimite;
                }

                Console.WriteLine($"Cliente: {nomes[i]} - Bônus: R$ {bonus:F2}");
            }
        }
    }
}