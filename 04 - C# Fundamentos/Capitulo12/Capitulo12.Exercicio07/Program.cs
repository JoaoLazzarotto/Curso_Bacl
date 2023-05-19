namespace Capitulo12.Exercicio7
{
    internal class Program
    {
        /*
         7. Construir um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja
            maior que 10, apresentá-lo.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero inteiro!");
            int numero1 = int.Parse(Console.ReadLine());   

            Console.WriteLine("Insira o segundo numero inteiro!");
            int numero2 = int.Parse(Console.ReadLine());

            int Resultado = numero1 + numero2; 

            if (Resultado > 10)
            {
                Console.WriteLine("O resultado é maior que 10");

            }

            else if (Resultado <= 10)
            {
                Console.WriteLine("O resultado é menor ou igual que 10");

            }
        }
    }
}