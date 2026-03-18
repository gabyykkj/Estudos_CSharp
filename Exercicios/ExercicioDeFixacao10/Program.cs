using System;

namespace ExercicioDeFixacao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da pirâmide: ");
            int tamanho = int.Parse(Console.ReadLine());

            Piramide(tamanho);
            PiramideInversa(tamanho);
        }
        
        static void Piramide( int x )
        {
            int inicio = 1;

            for( int i = x; i != 0; i--)
            {
                string espacos = new String(' ', i);
                string pontos = new String('*', inicio);
                Console.WriteLine(espacos + pontos);

                inicio += 2;
            }
        }

        static void PiramideInversa( int x )
        {
            int inicio = 1;

            for( int i = x; i != 1; i--)
            {
                inicio += 2;
            }

            for( int i = 1; i <= x; i++)
            {
                string espacos = new String(' ', i);
                string pontos = new string('*', inicio);
                inicio -= 2;


                Console.WriteLine(espacos + pontos);
            }
        }
    }
}