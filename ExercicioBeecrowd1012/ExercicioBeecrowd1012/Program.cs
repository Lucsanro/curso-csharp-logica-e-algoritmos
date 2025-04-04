﻿using System;
using System.Globalization;

namespace ExercicioBeecrowd1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2;
            double circulo = 3.14159 * (Math.Pow(C, 2.0));
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2.0);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " +   circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}