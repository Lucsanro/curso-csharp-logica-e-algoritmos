﻿using System;

namespace ExercicioBeecrowd1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}