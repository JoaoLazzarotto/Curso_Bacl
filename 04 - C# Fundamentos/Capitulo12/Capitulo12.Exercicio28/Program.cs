using System.Numerics;

namespace Capitulo12.Exercicio28
{
    internal class Program
    {
        /*
         28. A policia rodoviária resolveu fazer cumprir a lei e cobrar dos motoristas a DUT. Sabendo-se que o mês em
             que o emplacamento do carro deve ser renovado é determinado pelo último número da placa do mesmo, criar
             um algoritmo que, a partir da leitura da placa do carro, informe o mês em que o emplacamento deve ser
             renovado.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Para verificar mês do licenciamento insira a placa do seu veiculo.");
            string placa = Console.ReadLine();
            string ultimoNumero = placa.Substring(6, 1);


            if (ultimoNumero == "1" || ultimoNumero == "2" || ultimoNumero == "3")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de março." );
            }
            if (ultimoNumero == "4")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de abril.");
            }
            if (ultimoNumero == "5")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de maio.");
            }
            if (ultimoNumero == "6")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de junho.");
            }
            if (ultimoNumero == "7")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de julho.");
            }
            if (ultimoNumero == "8")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de agosto.");
            }
            if (ultimoNumero == "9")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de setembro.");
            }
            if (ultimoNumero == "0")
            {
                Console.WriteLine("O emplacamento deve ser renovado no mês de outubro.");
            }
          Console.ReadKey();    
        }
    }
}
