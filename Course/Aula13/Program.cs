using System;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros vai digitar? ");
            int x = int.Parse(Console.ReadLine());
            double soma = 0;

            for( int a = 1; a <= x; ++a)
            {
                Console.Write($"Digite o valor #{a}: ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Soma dos números: {soma}");
        }
    }
}