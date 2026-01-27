using System;
using System.Globalization;

namespace ExercicioDeFixacao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.InserirMedidas(largura, altura);

            double area = r.Area();
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            
            double perimetro = r.Perimetro();
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = r.Diagonal();
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}