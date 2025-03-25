using System;

namespace ExercicioBeecrowd1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsInter, golsGremio, vitoriaDoInter, vitoriaDoGremio, empate, grenais,
                novoGrenal;

            vitoriaDoInter = 0;
            vitoriaDoGremio = 0;
            empate = 0;
            grenais = 0;

            string[] vetor;

            do
            {
                vetor = Console.ReadLine().Split(' ');
                golsInter = int.Parse(vetor[0]);
                golsGremio = int.Parse(vetor[1]);

                if (golsInter > golsGremio)
                {
                    vitoriaDoInter += 1;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriaDoGremio += 1;
                }
                else
                {
                    empate += 1;
                }

                grenais += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

            } while (novoGrenal != 2);

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriaDoInter);
            Console.WriteLine("Gremio:" + vitoriaDoGremio);
            Console.WriteLine("Empates:" + empate);

            if (vitoriaDoInter > vitoriaDoGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriaDoGremio > vitoriaDoInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}