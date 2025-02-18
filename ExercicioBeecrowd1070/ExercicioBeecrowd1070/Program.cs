using System;

namespace ExercicioBeecrowd1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 != 0)
            {
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
            }
            else
            {
                X += 1;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
                X += 2;
                Console.WriteLine(X);
            }
        }
    }
}