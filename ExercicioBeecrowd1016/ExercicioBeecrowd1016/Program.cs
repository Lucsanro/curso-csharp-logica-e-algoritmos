using System;
using System.Globalization;

namespace ExercicioBeecrowd1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carro1 = 60, carro2 = 90;

            int km = int.Parse(Console.ReadLine());

            int distanciaEntreCarrosEmMinutos = km * 2;

            Console.WriteLine(distanciaEntreCarrosEmMinutos + " minutos");
        }
    }
}