namespace Capitulo12.Exercicio13
{
    internal class Program
    {
        /*
         13. Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens:
                • Carioca
                • Paulista
                • Mineiro
                • Outros estados
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sigla do seu estado");
            string estado = Console.ReadLine();
            estado = estado.ToUpper();

            if (estado == "RJ")
            {
                Console.WriteLine("Carioca");
                Console.ReadKey();
            }
            if (estado == "SP")
            {
                Console.WriteLine("Paulista");
                Console.ReadKey();
            }
            if (estado == "MG")
            {
                Console.WriteLine("Mineiro");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Outros estados");
            }
            Console.ReadKey();  
        }
    }
}