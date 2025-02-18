using System;
using System.Globalization;

namespace ExercicioResolvido09
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma = 0.0, contador = 0, media;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                soma += idade;
                contador += 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (contador == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / contador;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}