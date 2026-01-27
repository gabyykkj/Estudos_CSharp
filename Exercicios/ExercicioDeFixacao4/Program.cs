using System;

namespace ExercicioDeFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 101);

            bool condicao = true;

            while (condicao)
            {
                Console.WriteLine("Digite para adivinhar número");
                int palpite = int.Parse(Console.ReadLine());

                if(palpite == numero)
                {
                    Console.WriteLine($"Você achou o número!!  era {numero}");
                    condicao = false;
                }else if(palpite > numero)
                {
                    Console.WriteLine($"O número é menor que {palpite}");
                }
                else
                {
                    Console.WriteLine($"O número é maior que {palpite}");
                }
                Console.WriteLine();
            }
        }
    }
}