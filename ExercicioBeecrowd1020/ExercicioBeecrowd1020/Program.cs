using System;

namespace ExercicioBeecrowd1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int resto = idadeEmDias;

            int ano = 365;
            int calculo = resto / ano;
            Console.WriteLine(calculo + " ano(s)");
            resto = resto % ano;

            int mes = 30;
            calculo = resto / mes;
            Console.WriteLine(calculo + " mes(es)");
            resto = resto % mes;

            int dia = 1;
            calculo = resto / dia;
            Console.WriteLine(calculo + " dia(s)");

        }
    }
}