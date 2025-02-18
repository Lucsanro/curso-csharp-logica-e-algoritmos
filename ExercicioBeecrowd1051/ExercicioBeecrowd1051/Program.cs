using System;
using System.Globalization;

namespace ExercicioBeecrowd1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, faixaMenor,faixaMaior, impostoDeRenda;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.0 && salario <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                faixaMenor = salario - 2000.00;
                impostoDeRenda = faixaMenor * 0.08;
                Console.WriteLine("R$ " + impostoDeRenda.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.00 && salario <= 4500.00) 
            {
                faixaMenor = salario - 2000.00;
                if (faixaMenor > 1000.00)
                {
                    faixaMaior = faixaMenor - 1000.00;
                    faixaMenor -= faixaMaior;
                    impostoDeRenda = faixaMenor * 0.08 + faixaMaior * 0.18;
                    Console.WriteLine("R$ " + impostoDeRenda.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            else if (salario > 4500.00)
            {
                // 4520
                double salarioMaior;
                salarioMaior = salario - 2000;
                faixaMenor = 1000.00; // 1000
                salarioMaior -= faixaMenor; // 1520
                faixaMaior = 1500.00; // 1500
                salarioMaior -= faixaMaior; // 20

                impostoDeRenda = faixaMenor * 0.08 + faixaMaior * 0.18 + salarioMaior * 0.28;
                Console.WriteLine("R$ " + impostoDeRenda.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}