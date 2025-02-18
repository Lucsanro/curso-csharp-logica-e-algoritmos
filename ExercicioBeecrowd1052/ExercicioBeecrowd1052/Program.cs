using System;

namespace ExercicioBeecrowd1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDoMes = int.Parse(Console.ReadLine());
            string month;

            switch (numeroDoMes)
            {
                case 1:
                    month = "January";
                    Console.WriteLine(month);
                    break;
                case 2:
                    month = "February";
                    Console.WriteLine(month);
                    break;
                case 3:
                    month = "March";
                    Console.WriteLine(month);
                    break;
                case 4:
                    month = "April";
                    Console.WriteLine(month);
                    break;
                case 5:
                    month = "May";
                    Console.WriteLine(month);
                    break;
                case 6:
                    month = "June";
                    Console.WriteLine(month);
                    break;
                case 7:
                    month = "July";
                    Console.WriteLine(month);
                    break;
                case 8:
                    month = "August";
                    Console.WriteLine(month);
                    break;
                case 9:
                    month = "September";
                    Console.WriteLine(month);
                    break;
                case 10:
                    month = "October";
                    Console.WriteLine(month);
                    break;
                case 11:
                    month = "November";
                    Console.WriteLine(month);
                    break;
                case 12:
                    month = "December";
                    Console.WriteLine(month);
                    break;
            }
        }
    }
}