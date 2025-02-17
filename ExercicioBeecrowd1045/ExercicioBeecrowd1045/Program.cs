using System;
using System.Globalization;

namespace ExercicioBeecrowd1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, funcaoBC, valorDeA, valorDeB;

            string[] vetor = Console.ReadLine().Split();
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (A == B && A == C) // 6 6 6
            {
                // nenhuma alteração necessária
            } 
            else if (B == C) //2 6 6 
            {
                if(A < B)
                {
                    valorDeA = A;
                    A = B;
                    C = valorDeA;
                }
            }
            else if (A > B && A >= C) // 6 2 6
            {
                valorDeB = B;
                B = C;
                C = valorDeB;
            }
            else if (A < B && B > C) // 3 9 6
            {
                valorDeA = A;
                A = B;
                B = C;
                C = valorDeA;
            }
            else if (A < C && B < C) // 3 6 9
            {
                valorDeA = A;
                A = C;
                C = valorDeA;
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(A, 2.0) < Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && A == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            } 
        }
    }
}