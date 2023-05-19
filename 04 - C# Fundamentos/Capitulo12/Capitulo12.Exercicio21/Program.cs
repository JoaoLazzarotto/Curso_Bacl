namespace Capitulo12.Exercicio21
{
    internal class Program
    {
        /*
         21. Entrar com três números e imprimi-los em ordem decrescente (suponha números diferentes).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            float numero3 = float.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero2 > numero3)
            {
                Console.WriteLine(numero1 + ", " + numero2 + ", " + numero3);
                Console.ReadLine();
            }

            if (numero1 > numero3 && numero3 > numero2)
            {
                Console.WriteLine(numero1 + ", " + numero3 + ", " + numero2);
                Console.ReadLine();
            }

            if (numero2 > numero1 && numero1 > numero3)
            {
                Console.WriteLine(numero2 + ", " + numero1 + ", " + numero3);
                Console.ReadLine();
            }

            if (numero2 > numero3 && numero3 > numero1)
            {
                Console.WriteLine(numero2 + ", " + numero3 + ", " + numero1);
                Console.ReadLine();
            }

            if (numero3 > numero1 && numero1 > numero2)
            {
                Console.WriteLine(numero3 + ", " + numero1 + ", " + numero2);
                Console.ReadLine();
            }

            if (numero3 > numero2 && numero2 > numero1)
            {
                Console.WriteLine(numero3 + ", " + numero2 + ", " + numero1);
                Console.ReadLine();
            }
        }
    }
}