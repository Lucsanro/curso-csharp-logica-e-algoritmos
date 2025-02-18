using System;

namespace ExercicioBeecrowd1060
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, f, contador = 0;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            d = float.Parse(Console.ReadLine());
            e = float.Parse(Console.ReadLine());
            f = float.Parse(Console.ReadLine());

            if (a > 0)
            {
                contador += 1;
            }
            if (b > 0)
            {
                contador += 1;
            }
            if (c > 0)
            {
                contador += 1;
            }
            if (d > 0)
            {
                contador += 1;
            }
            if (e > 0)
            {
                contador += 1;
            }
            if (f > 0)
            {
                contador += 1;
            }

            Console.WriteLine(contador.ToString("F0") + " valores positivos");
        }
    }
}