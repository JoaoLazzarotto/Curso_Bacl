using System.Drawing;

namespace Capitulo12.Exercicio5
{
    internal class Program
    {
        /*
         5. Uma pessoa resolveu fazer uma aplicação em uma poupança programada. Para calcular seu rendimento, ela
            devera fornecer o valor constante da aplicação mensal, a taxa e o número de meses. Sabendo-se que a
            formula usada para este calculo é:
                
                Valor acumulado = P * ((1+i)n -1)/i
                i = taxa
                P = aplicação mensal
                n = número de meses (obs. (1+i) elevado a n)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Qual será o valor da aplicação mensal?");
            double valorAplicação = double.Parse(Console.ReadLine());

            Console.WriteLine("Você vai aplicar por quanto tempo (em meses)?");
            double meses = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da taxa mensal da aplicação(% ao mês)?");
            double Taxa1 = double.Parse(Console.ReadLine());



            double Taxa = Taxa1 / 100;
           
            double potenciaçao = Math.Pow(1 + Taxa, meses);
            Console.WriteLine(potenciaçao);

            double potenciacao1 = potenciaçao - 1;

            double calculo = valorAplicação * potenciacao1;

            double calculoFinal = calculo / Taxa;


            Console.WriteLine($"Valor acumulado após todos os depósitos mensais {calculoFinal.ToString("C")}");    

        }
    }
}