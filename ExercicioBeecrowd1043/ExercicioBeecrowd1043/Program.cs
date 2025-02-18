using System;
using System.Globalization;

namespace ExercicioBeecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vetor = Console.ReadLine().Split();
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B) // lógica do professor
            {
                double perimetro;
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));

            }
            else
            {
                double area;
                area = (A + B) * C / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
