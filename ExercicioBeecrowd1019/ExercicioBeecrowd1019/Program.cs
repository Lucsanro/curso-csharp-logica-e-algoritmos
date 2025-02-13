using System;

namespace ExercicioBeecrowd1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int horaEmSegundos = 3600, minutoEmSegundos = 60;

            int hora = n / horaEmSegundos;
            int minutos = (n % horaEmSegundos) / minutoEmSegundos;
            int segundos = (n % horaEmSegundos) % minutoEmSegundos;

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);
        }
    }
}