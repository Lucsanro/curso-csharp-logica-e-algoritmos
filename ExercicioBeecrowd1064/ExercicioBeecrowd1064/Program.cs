using System;
using System.Globalization;

namespace ExercicioBeecrowd1064
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, f, contador = 0, media;

            a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0)
            {
                contador += 1;
            }
            else
            {
                a = 0;
            }
            if (b > 0)
            {
                contador += 1;
            }
            else
            {
                b = 0;
            }
            if (c > 0)
            {
                contador += 1;
            }
            else
            {
                c = 0;
            }
            if (d > 0)
            {
                contador += 1;
            }
            else
            {
                d = 0;
            }
            if (e > 0)
            {
                contador += 1;
            }
            else
            {
                e = 0;
            }
            if (f > 0)
            {
                contador += 1;
            }
            else
            {
                f = 0;
            }

            media = (float) (a + b + c + d + e + f) / contador;

            Console.WriteLine(contador.ToString("F0") + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}