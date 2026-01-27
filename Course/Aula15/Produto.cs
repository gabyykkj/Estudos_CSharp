using System;
using System.Globalization;

namespace Aula15
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public override string ToString()
        {
            return Nome + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " 
            + Quantidade 
            + " unidades, Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void CadastrarProduto()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Preço: ");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            Quantidade = int.Parse(Console.ReadLine());
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos()
        {
            int qte = int.Parse(Console.ReadLine());
            Quantidade += qte;
        }

        public void RemoverProdutos()
        {
            int qte = int.Parse(Console.ReadLine());
            Quantidade -= qte;
        }
    }
}