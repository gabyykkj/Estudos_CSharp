using System;
using System.Globalization;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
        //    SemPOO();
        ComPOO();
        }
        static void SemPOO()
        {
             double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }
        }
        static void ComPOO()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = InserirMedidas();
            x.B = InserirMedidas();
            x.C = InserirMedidas();
            
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = InserirMedidas();
            y.B = InserirMedidas();
            y.C = InserirMedidas();
            
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }
        }
        static double InserirMedidas()
        {
            double a;
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return a;
        }
    }
}