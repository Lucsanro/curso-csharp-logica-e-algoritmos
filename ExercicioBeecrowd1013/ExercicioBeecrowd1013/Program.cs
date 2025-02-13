using System;
using System.Globalization;

namespace ExercicioBeecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;

            int resultado = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(resultado + " eh o maior");

        }
    }
}