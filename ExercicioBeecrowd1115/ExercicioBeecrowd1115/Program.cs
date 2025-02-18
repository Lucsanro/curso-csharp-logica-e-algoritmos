using System;

namespace ExercicioBeecrowd1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vetor = Console.ReadLine().Split();
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    vetor = Console.ReadLine().Split();
                    x = int.Parse(vetor[0]);
                    y = int.Parse(vetor[1]);
                }
            }
        }
    }
}