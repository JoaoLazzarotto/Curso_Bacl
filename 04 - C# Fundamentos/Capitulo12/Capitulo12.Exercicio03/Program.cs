namespace Capitulo12.Exercicio3
{
    internal class Program
    {
        /*
         3. Criar um algoritmo que efetue o cálculo do salário líquido de um professor. Os dados fornecidos serão: valor
            da hora aula, numero de aulas dadas no mês e percentual de desconto do INSS.

            Considere a tabela do INSS de 2023:
                - Até R$1.302,00 – 7,5%
                - De R$1.302,00 até R$2.571,29 – 9%
                - De R$2.571,30 até R$3.856,94 – 12%
                - De R$3.856,95 até R$7.507,49 – 14%
         */
        static void Main(string[] args)
        {
            
            Console.Write("Informe o valor da hora aula: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.Write("Informe o número de aulas dadas no mês: ");
            int numAulas = int.Parse(Console.ReadLine());            
 
            
            double salarioBruto = valorHora * numAulas;            
            double descontoINSS = 0;


            if (salarioBruto <= 1302)
            {
                descontoINSS = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2571.29)
            {
                descontoINSS = salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3856.94)
            {
                descontoINSS = salarioBruto * 0.12;
            }
            else if (salarioBruto <= 7507.49)
            {
                descontoINSS = salarioBruto * 0.14;
            }
            else
            {
                descontoINSS = 7507.49 * 0.14; 
            }


           
            double salarioLiquido = salarioBruto - descontoINSS;

            
            Console.WriteLine("Salário líquido: R$ " + salarioLiquido.ToString("F2"));
        }
    }
}