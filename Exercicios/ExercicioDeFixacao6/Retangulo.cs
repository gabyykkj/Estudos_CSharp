using System;
using System.Globalization;

namespace ExercicioDeFixacao6
{
    class Retangulo
    {
        public double Largura { get; private set ; }
        public double Altura { get; private set ; }

        public void InserirMedidas(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double quadrado = (Math.Pow(Largura, 2)) + (Math.Pow(Altura, 2));
            return Math.Sqrt(quadrado);
        }
    }
}