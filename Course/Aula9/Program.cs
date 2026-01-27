using System;

namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
        }
        static void Exemplo1()
        {
            bool c1 = 2 > 3 && 4 != 5 ;
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5 ;
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c3);

            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}