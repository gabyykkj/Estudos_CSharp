using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo1();
            // Exemplo2();
            Exemplo3();
        }
        static void Exemplo1()
        {

            int x = 10;

            Console.WriteLine("Bom dia");
            if (x < 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");
        }
        static void Exemplo2()
        {
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
        }
        static void Exemplo3()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if(hora <= 18)
            {
                Console.WriteLine("Boa Tarde!");
            }else if(hora <= 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("A hora inserida é inválida");
            }
        }
    }
}