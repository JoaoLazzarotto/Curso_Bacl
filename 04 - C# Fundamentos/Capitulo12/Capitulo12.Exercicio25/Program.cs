namespace Capitulo12.Exercicio25
{
    internal class Program
    {
        /*
         25. Entrar com nome, nota da PR1 e nota da PR2 de um aluno, imprimir nome, nota da PR1, nota da PR2,
             média e uma das mensagens: APROVADO, REPROVADO ou EXAME ( a média é 7 para aprovação, menor que 3
             para reprovação e as demais em exame).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira a nota da primeira prova:");
            double prova1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota da segunda prova:");
            double prova2 = double.Parse(Console.ReadLine());

            nome = nome.ToUpper();

            Console.WriteLine($"Olá {nome},");

            Console.WriteLine(prova1);

            Console.WriteLine(prova2);

            double media = (prova1 + prova2) / 2;

            if (media >= 7)
            {
                Console.WriteLine($"Parabéns,{nome} você está APROVADO!!!");    
            }
            else if (media < 3)
            {
                Console.WriteLine($"{nome} infelizmente você está REPROVADO!!!");
            }
            else
            {
                Console.WriteLine($"{nome} você está em EXAME!!!");
            }




        }
    }
}