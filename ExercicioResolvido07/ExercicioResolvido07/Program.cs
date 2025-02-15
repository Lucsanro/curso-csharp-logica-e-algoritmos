using System;
using System.Globalization;

namespace ExercicioResolvido07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < c)
            {
                Console.WriteLine("MENOR = " + b);
            }
            else
            {
                Console.WriteLine("MENOR = " + c);

            }
        }
    }
}