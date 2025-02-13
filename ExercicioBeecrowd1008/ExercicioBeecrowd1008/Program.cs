using System;
using System.Globalization;

namespace ExercicioBeecrowd1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorDaHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorDaHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}