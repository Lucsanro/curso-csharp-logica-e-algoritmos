using System;

namespace ExercicioBeecrowd1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, paresDeX, ajusteXseNaoForPar;

            paresDeX = 0;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    ajusteXseNaoForPar = X + 1;
                    paresDeX = ajusteXseNaoForPar;
                    ajusteXseNaoForPar += 2;
                    paresDeX += ajusteXseNaoForPar;
                    ajusteXseNaoForPar += 2;
                    paresDeX += ajusteXseNaoForPar;
                    ajusteXseNaoForPar += 2;
                    paresDeX += ajusteXseNaoForPar;
                    ajusteXseNaoForPar += 2;
                    paresDeX += ajusteXseNaoForPar;
                    Console.WriteLine(paresDeX);
                    X = int.Parse(Console.ReadLine());
                }
                else
                {
                    paresDeX = X;
                    X += 2;
                    paresDeX += X;
                    X += 2;
                    paresDeX += X;
                    X += 2;
                    paresDeX += X;
                    X += 2;
                    paresDeX += X;
                    Console.WriteLine(paresDeX);
                    X = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}