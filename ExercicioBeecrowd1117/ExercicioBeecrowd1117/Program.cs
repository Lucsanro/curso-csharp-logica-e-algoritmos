using System;
using System.Globalization;

namespace ExercicioBeecrowd1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (nota1 < 0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            resultado = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}