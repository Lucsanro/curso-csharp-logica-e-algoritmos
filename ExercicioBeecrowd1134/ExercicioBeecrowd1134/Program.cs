using System;

namespace ExercicioBeecrowd1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel, combustivel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    alcool += 1;
                }
                if (combustivel == 2)
                {
                    gasolina += 1;
                }
                if (combustivel == 3)
                {
                    diesel += 1;
                }
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}