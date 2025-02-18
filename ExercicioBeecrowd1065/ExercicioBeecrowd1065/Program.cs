using System;

namespace ExercicioBeecrowd1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, contador = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (Math.Abs(a) % 2 == 0)
            {
                contador += 1;
            }
            if (Math.Abs(b) % 2 == 0)
            {
                contador += 1;
            }
            if (Math.Abs(c) % 2 == 0)
            {
                contador += 1;
            }
            if (Math.Abs(d) % 2 == 0)
            {
                contador += 1;
            }
            if (Math.Abs(e) % 2 == 0)
            {
                contador += 1;
            }

            Console.WriteLine(contador + " valores pares");
        }
    }
}