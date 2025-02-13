using System;
using System.Globalization;

namespace ExercicioBeecrowd1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioTotal = salario + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}