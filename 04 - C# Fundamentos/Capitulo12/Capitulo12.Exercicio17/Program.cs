namespace Capitulo12.Exercicio17
{
    internal class Program
    {
        /*
         17. Entrar com dois números e imprimi-los em ordem crescente (suponha números diferentes).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número!");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número!");
            float numero2 = float.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + ", " + numero2);
                Console.ReadLine();
            }
            if (numero2 < numero1)
            {
                Console.WriteLine(numero2 + ", " + numero1);
                Console.ReadLine();
            }
        }
    }
}