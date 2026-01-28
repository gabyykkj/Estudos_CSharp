using System;
using System.Globalization;

namespace ExercicioDeFixacao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Valor = ConversorDeMoedas.ConverterParaReais(cotacao, quantidade);

            Console.WriteLine($"Valor aser pago em reais = {Valor.ToString("0.00", CultureInfo.InvariantCulture)}");
        }
    }
}