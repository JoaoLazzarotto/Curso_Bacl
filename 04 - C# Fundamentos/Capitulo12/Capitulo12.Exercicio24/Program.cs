namespace Capitulo12.Exercicio24
{
    internal class Program
    {
        /*
         24. Entrar com a idade de uma pessoa e informar:
            • Se é maior de idade
            • Se é menor de idade
            • Se é maior de 65 anos
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 65)
            {
                Console.WriteLine("É maior de 65 anos.");             

            }
            

            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade.");
               
            }
            

            if (idade < 18)
            {
                Console.WriteLine("É menor de idade.");
                           
            }
           

        }
    }
}