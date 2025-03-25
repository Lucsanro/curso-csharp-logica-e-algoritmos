using System;
using System.Globalization;

namespace ExercicioBeecrowd1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdade, contadorIdade;
            double mediaIdade;

            somaIdade = 0;
            contadorIdade = 0;
            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                somaIdade += idade;
                contadorIdade += 1;
                idade = int.Parse(Console.ReadLine());

            }

            mediaIdade = (double) somaIdade / contadorIdade;

            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}