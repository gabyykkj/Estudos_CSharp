using System;
using System.Globalization;

namespace ExercicioDeFicacao9
{
    class Banco
    {
        private string _titular;
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

        public Banco(){}

        public Banco(string titular, int numero )
        {
            _titular = titular;
            Numero = numero;
            Saldo = 0.00;
        }

        public Banco(string titular, int numero, double depositoInicial) : this(titular, numero)
        {
            Deposito(depositoInicial);        
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if( value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }
        
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque( double saque)
        {
            Saldo = Saldo - saque - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + _titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}