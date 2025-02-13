using System;
using System.Globalization;

namespace ExercicioBeecrowd1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, consumoAutomovel = 12;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            double combustivel = (double) tempo * velocidade / consumoAutomovel;

            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}