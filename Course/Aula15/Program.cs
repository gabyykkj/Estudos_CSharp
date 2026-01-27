using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            p.CadastrarProduto();

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos();

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write($"Digite o número de produtos a ser removido ao estoque: ");
            p.RemoverProdutos();

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}