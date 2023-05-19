namespace Capitulo12.Exercicio9
{
    internal class Program
    {
        /*
         9. A prefeitura do Rio de Janeiro abriu uma linha de crédito para os funcionários estatutários. O valor Máximo
            da prestação não poderá ultrapassar 30% do salário bruto. Fazer um programa que permita entrar com o
            salário bruto e o valor da prestação e informa se o empréstimo pode ou não ser concedido.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do seu salário bruto, para verificar se é possível o empréstimo!");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da linha de crédito, para verificar se é possível o empréstimo!");
            double linhaCredito = double.Parse(Console.ReadLine());

            var regraDe3 = linhaCredito * 100;

            var resultadoFinal = regraDe3 / salarioBruto;

            Console.WriteLine($"O valor da prestação é {Math.Round(resultadoFinal)}% em relação ao salário bruto.");

            if (resultadoFinal <= 30) 
            {

                Console.WriteLine("O empréstimo pode ser concedido");
            }

            else if (resultadoFinal > 30)
            {

                Console.WriteLine("O empréstimo não pode ser concedido");
            } 

           
        }
    }
}