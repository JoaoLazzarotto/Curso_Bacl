namespace Capitulo12.Exercicio8
{
    internal class Program
    {
        /*
         8. Construir um algoritmo que leia dois números e efetue a adição. Caso o valor somado seja maior que 20,
            este devera ser apresentado somando-se a ele mais 8; caso o valor somado seja menor ou igual a 20, este
            devera ser apresentado subtraindo-se 5.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double numero2 = double.Parse(Console.ReadLine());

            double ResultadoSoma = numero1 + numero2;


            if (ResultadoSoma > 20) {

                var Soma8 = ResultadoSoma + 8;
                Console.WriteLine("O resultado é " + Soma8);          
            
            }

            else if (ResultadoSoma <= 20)
            {

                var Sub5 = ResultadoSoma - 5;
                Console.WriteLine("O resultado é " + Sub5);

            }






        }
    }
}