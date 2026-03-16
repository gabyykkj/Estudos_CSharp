using System;

namespace ExercicioDeFixacao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da pirâmide: ");
            int tamanho = int.Parse(Console.ReadLine());
            int inicio = 1;

            for( int i = tamanho; i != 0; i--)
            {
                string resultado = new String(' ', i);
                string pontos = new String('*', inicio);
                Console.WriteLine(resultado + pontos);

                inicio += 2;
            }
        }
    }
}