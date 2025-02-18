using System;

namespace ExercicioBeecrowd1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, a1, b2, c3, alteraB, alteraC;

            string[] vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            a1 = a;
            b2 = b;
            c3 = c;

            // 3 6 9 nao faço nada
            // 6 6 6 nao faço nada
            // 3 6 6 nao faço nada

            if (a < b && a < c) // 3 9 6
            {
                if (b > c)
                {
                    alteraB = b;
                    b = c;
                    c = alteraB;
                }
            }
            else if (a < b && a > c) // 6 9 3
            {
                alteraC = c;
                alteraB = b;
                b = a;
                a = alteraC;
                c = alteraB;
            }
            else if (a > b && a < c) // 6 3 9
            {
                alteraB = b;
                b = a;
                a = alteraB;
            }
            else if (a > b && a > c) // 9 6 3
            {
                if (b > c)
                {
                    alteraC = c;
                    c = a;
                    a = alteraC;
                } 
                else if (c > b) // 9 3 6
                {
                    alteraB = b;
                    alteraC = c;
                    c = a;
                    a = alteraB;
                    b = alteraC;
                }
            }
            else if (a == b && a != c) // 6 6 3
            {
                alteraC = c;
                c = a;
                a = alteraC;
            }
            else if (a != b && a == c) // 6 3 6
            {
                alteraB = b;
                b = a;
                a = alteraB;
            }


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(a1);
            Console.WriteLine(b2);
            Console.WriteLine(c3);
        }
    }
}