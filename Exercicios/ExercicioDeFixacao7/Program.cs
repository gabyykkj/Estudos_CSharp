using System;
using System.Globalization;

namespace ExercicioDeFixacao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            F.InserirDados(nome, salarioBruto, imposto);

            Console.WriteLine($"Funcionário : {F}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados : {F}");
        }
    }
}