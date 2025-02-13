using System;
using System.Globalization;

namespace ExercicioBeecrowd1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            string[] vetor = Console.ReadLine().Split(' ');
            x1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' ');
            x2 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}