using System;

namespace ExercicioDeFixacao8
{
    class ConversorDeMoedas
    {

        public static double Iof = 6.0;

        public static double ConverterParaReais(double cotacao, double quantidade)
        {
            double total = quantidade * cotacao;
            return total + total * Iof / 100.0;            
        }
    }
}