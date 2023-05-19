namespace Capitulo12.Exercicio10
{
    internal class Program
    {
        /*
         10. Construir um algoritmo que indique se o número digitado esta compreendido entre 20 e 90 ou não.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero");
            double numero = double.Parse(Console.ReadLine()); 
            
            if (numero >= 20 && numero <= 90) 
            {
                Console.WriteLine("O número está compreendido entre 20 e 90");
            
            }
            else
            {
                Console.WriteLine("O número não está compreendido entre 20 e 90");

            }  
            
        }
    }
}