using System;
using System.ComponentModel;

namespace ExercicioDeFixacao11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 2, 7, 3, 1, 4, 8, 9, 6 };

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int troca1 = numeros[i];
                        int troca2 = numeros[j];

                        numeros[i] = troca2;
                        numeros[j] = troca1;
                    }
                }
                foreach (int numero in numeros)
                {
                    string x = new String('#', numero);
                    // Console.WriteLine(x);
                }
                // Console.WriteLine("----------------------------------------");
            }

        string[,] matriz = new string[9, 9];

        // Colocar na diagonal (i = linha, i = coluna)
        for (int i = 0; i < numeros.Length; i++)
        {
            for( int j = 0; j < numeros[i]; j++)
                {
                    matriz[i, j] = "#";
                }
        }

        // --- Exibir o resultado ---
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); // Pula linha
        }
        }
    }
}