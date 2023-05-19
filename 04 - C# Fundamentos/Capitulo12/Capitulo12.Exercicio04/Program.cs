namespace Capitulo12.Exercicio4
{
    internal class Program
    {
        /*
         4. Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10% para o garçom. Fazer um
            algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com
            gorjeta.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor gasto da refeição! Ex: 24,42");
            var valorRefeicao = double.Parse(Console.ReadLine());

            var valorTotal = valorRefeicao * 1.1;
            Console.WriteLine($"O valor total da refeição foi: {valorTotal.ToString("C")}");


        }
    }
}