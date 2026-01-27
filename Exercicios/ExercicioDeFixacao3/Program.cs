using System;

namespace ExercicioDeFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite um operador: ");
            string operador = Console.ReadLine();
            double soma = 0;

            switch (operador)
            {
                case "+":
                    soma = n1 + n2;
                    Console.WriteLine($"Soma: {soma}");
                    break;
                case "-":
                    soma = n1 - n2;
                    Console.WriteLine($"Subtração: {soma}");
                    break;
                case "*":
                    soma = n1 * n2;
                    Console.WriteLine($"Multiplicação: {soma}");
                    break;
                case "/":
                    soma = n1 / n2;
                    Console.WriteLine($"Divisão: {soma}");
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    break;
            }
        }
    }
}