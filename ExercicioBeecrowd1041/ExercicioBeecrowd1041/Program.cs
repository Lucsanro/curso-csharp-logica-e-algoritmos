﻿using System;
using System.Globalization;

namespace ExercicioBeecrowd1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] vetor = Console.ReadLine().Split();
            x = double.Parse(vetor[0]);
            y = double.Parse(vetor[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y != 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0.0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}