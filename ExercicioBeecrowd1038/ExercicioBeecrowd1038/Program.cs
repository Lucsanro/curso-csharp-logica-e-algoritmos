using System;
using System.Globalization;

namespace ExercicioBeecrowd1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double precoFinal;

            string[] vetor = Console.ReadLine().Split();
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            switch (codigo)
            {
                case 1:
                    precoFinal = quantidade * 4.00;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 2:
                    precoFinal = quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 3:
                    precoFinal = quantidade * 5.00;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 4:
                    precoFinal = quantidade * 2.00;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 5:
                    precoFinal = quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

                    break;
            }
        }
    }
}