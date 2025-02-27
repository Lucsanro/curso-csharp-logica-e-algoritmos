﻿using System;

namespace ExercicioBeecrowd1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double _100, _50, _20, _10, _5, _2, _1;

            _100 = (int) N / 100;
            _50 = (int) (N % 100) / 50;
            _20 = (int) ((N % 100) % 50) / 20;
            _10 = (int) (((N % 100) % 50) % 20) / 10;
            _5 = (int)  ((((N % 100) % 50) % 20) % 10) / 5;
            _2 = (int)  (((((N % 100) % 50) % 20) % 10) % 5) / 2;
            _1 = (int)  ((((((N % 100) % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine(N);
            Console.WriteLine(_100 + " nota(s) de R$ 100,00");
            Console.WriteLine(_50 + " nota(s) de R$ 50,00");
            Console.WriteLine(_20 + " nota(s) de R$ 20,00");
            Console.WriteLine(_10 + " nota(s) de R$ 10,00");
            Console.WriteLine(_5 + " nota(s) de R$ 5,00");
            Console.WriteLine(_2 + " nota(s) de R$ 2,00");
            Console.WriteLine(_1 + " nota(s) de R$ 1,00");
        }
    }
}