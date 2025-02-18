using System;

namespace ExercicioBeecrowd1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e,
                contadorPar = 0, contadorImpar = 0, contadorPositivo = 0, contadorNegativo = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (Math.Abs(a) % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }
            if (Math.Abs(b) % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }
            if (Math.Abs(c) % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }
            if (Math.Abs(d) % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }
            if (Math.Abs(e) % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }


            if (a != 0 && a > 0)
            {
                contadorPositivo += 1;
            }
            if (b != 0 && b > 0)
            {
                contadorPositivo += 1;
            }
            if (c != 0 && c > 0)
            {
                contadorPositivo += 1;
            }
            if (d != 0 && d > 0)
            {
                contadorPositivo += 1;
            }
            if (e != 0 && e > 0)
            {
                contadorPositivo += 1;
            }

            if (a != 0 && a < 0)
            {
                contadorNegativo += 1;
            }
            if (b != 0 && b < 0)
            {
                contadorNegativo += 1;
            }
            if (c != 0 && c < 0)
            {
                contadorNegativo += 1;
            }
            if (d != 0 && d < 0)
            {
                contadorNegativo += 1;
            }
            if (e != 0 && e < 0)
            {
                contadorNegativo += 1;
            }

            Console.WriteLine(contadorPar + " valor(es) par(es)");
            Console.WriteLine(contadorImpar + " valor(es) impar(es)");
            Console.WriteLine(contadorPositivo + " valor(es) positivo(s)");
            Console.WriteLine(contadorNegativo + " valor(es) negativo(s)");
        }
    }
}