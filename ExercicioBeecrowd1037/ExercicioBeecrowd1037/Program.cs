using System;
using System.Globalization;

namespace ExercicioBeecrowd1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.0 && numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero > 25.0 && numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero > 50.0 && numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero > 75.0 && numero <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}