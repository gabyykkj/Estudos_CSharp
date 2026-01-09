using System;

namespace Aula3
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
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);
        }
        static void Exemplo2()
        {
            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}