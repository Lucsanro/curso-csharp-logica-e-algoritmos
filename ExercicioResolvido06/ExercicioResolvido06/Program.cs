﻿using System;
using System.Globalization;

namespace ExercicioResolvido06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            string[] vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0.0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            } 
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}