namespace Capitulo12.Exercicio12
{
    internal class Program
    {
        /*
         12. Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo feminino e tiver menos que 25
             anos, imprimir nome e a mensagem: ACEITA. Caso contrário, imprimir nome e a mensagem: NÃO ACEITA.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome completo.");
            string nomeCompleto = Console.ReadLine();
            

            Console.WriteLine("Insira o seu sexo. (Masculino ou Feminino)");
            string sexo = Console.ReadLine();
            sexo = sexo.ToLower();

            Console.WriteLine("Insira a sua idade.");
            int idade = int.Parse(Console.ReadLine());

            if (sexo == "feminino" && idade < 25)
            {
                Console.WriteLine("Parabéns " + nomeCompleto + ", você foi ACEITA!");                 

            }

            else
            {
                Console.WriteLine(nomeCompleto + ", infelizmente você não foi aceito(a)!");
            }


        }
    }
}