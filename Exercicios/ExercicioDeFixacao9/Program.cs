using System;
using System.Globalization;

namespace ExercicioDeFicacao9
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string x = Console.ReadLine();

            if( x == "s" || x == "S" )
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Banco(titular, numero, valor_inicial);
            }
            else
            {
                conta = new Banco(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}