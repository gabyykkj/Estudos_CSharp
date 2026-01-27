using System;

namespace ExercicioDeFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cadastre o aluno(a) com o nome: ");
            string nome_aluno = Console.ReadLine();

            Console.Write("Inserir primeira nota do aluno: ");
            float nota1 = float.Parse(Console.ReadLine());
            
            Console.Write("Inserir segunda nota do aluno: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = Media(nota1, nota2);
            Console.WriteLine($"O aluno(a) {nome_aluno}, tem a média de {media.ToString("F1")}"); 
        }
        static float Media(float a, float b)
        {
            float soma = a + b;
            float media = soma / 2;
            return media;
        }
    }
}