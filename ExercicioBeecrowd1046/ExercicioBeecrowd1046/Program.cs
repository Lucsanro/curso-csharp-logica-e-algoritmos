using System;

namespace Beecrowd1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, tempoDeJogo;

            string[] vetor = Console.ReadLine().Split();
            horaInicial = int.Parse(vetor[0]);
            horaFinal = int.Parse(vetor[1]);

            if (horaInicial > horaFinal)
            {
                tempoDeJogo = (24 - horaInicial) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }
            else if (horaFinal > horaInicial)
            {
                tempoDeJogo = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }
            else
            {
                tempoDeJogo = 24;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }


        }
    }
}