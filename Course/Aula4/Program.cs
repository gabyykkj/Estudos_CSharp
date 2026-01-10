using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
        }
        static void Exemplo1()
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);
        }
        static void Exemplo2()
        {
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;

            Console.WriteLine(resultado);
        }
    }
}