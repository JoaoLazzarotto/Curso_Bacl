namespace Capitulo12.Exercicio26
{
    internal class Program
    {
        /*
         26. Um comerciante comprou um produto e quer vende-lo com um lucro de 45% se o valor da compra for
             menor que R$ 20,00; caso contrario, o lucro será de 30%. Entrar com o valor do produto e imprimir o valor da
             venda.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor que foi comprado o produto, para verificar o valor final do produto.");
            double valorInicial = double.Parse(Console.ReadLine());

            if(valorInicial < 20)
            {
                
                Console.WriteLine($"O valor de venda do produto é {(valorInicial / 0.45).ToString("C")}");
            }
            else
            {

                Console.WriteLine($"O valor de venda do produto é {(valorInicial / 0.3).ToString("C")}");
            }

        }
    }
}