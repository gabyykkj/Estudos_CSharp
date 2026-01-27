using System;
using System.Globalization;

namespace ExercicioDeFixacao7
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }

        public override string ToString()
        {
            return Nome 
            + ", $ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void InserirDados(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *=  1.0 + (porcentagem / 100.0);
        }
    }
}