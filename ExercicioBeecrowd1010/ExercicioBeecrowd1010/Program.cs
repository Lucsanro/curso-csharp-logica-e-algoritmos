using System;
using System.Globalization;

namespace ExercicioBeecrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, qtdPeca1, qtdPeca2;
            double valorPeca1, valorPeca2, totalAPagar;

            string[] vetorPeca1 = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vetorPeca1[0]);
            qtdPeca1 = int.Parse(vetorPeca1[1]);
            valorPeca1 = double.Parse(vetorPeca1[2], CultureInfo.InvariantCulture);

            string[] vetorPeca2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vetorPeca2[0]);
            qtdPeca2 = int.Parse(vetorPeca2[1]);
            valorPeca2 = double.Parse(vetorPeca2[2], CultureInfo.InvariantCulture);

            totalAPagar = (valorPeca1 * qtdPeca1) + (valorPeca2 * qtdPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}