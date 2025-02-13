using System;
using System.Globalization;

namespace ExercicioBeecrowd1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi = 3.14159, volume;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (double)(4.0 / 3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}