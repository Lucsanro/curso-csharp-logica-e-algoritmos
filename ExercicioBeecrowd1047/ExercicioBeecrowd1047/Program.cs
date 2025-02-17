using System;
using System.Globalization;

namespace ExercicioBeecrowd1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, duracaoHora, duracaoMinuto;

            string[] vetor = Console.ReadLine().Split();
            horaInicial = int.Parse(vetor[0]);
            minutoInicial = int.Parse(vetor[1]);
            horaFinal = int.Parse(vetor[2]);
            minutoFinal = int.Parse(vetor[3]);

            // calculo das horas
            if (horaInicial < horaFinal)
            {
                duracaoHora = horaFinal - horaInicial;
            }
            else if (horaInicial > horaFinal)
            {
                duracaoHora = 24 - (horaInicial - horaFinal);
            }
            else
            {
                duracaoHora = 24;
            }

            // calculo dos minutos
            if (minutoInicial < minutoFinal)
            {
                duracaoMinuto = minutoFinal - minutoInicial;
                if (horaInicial == horaFinal)
                {
                    duracaoHora = 0;
                }
            }
            else if (minutoInicial > minutoFinal)
            {
                duracaoMinuto = 60 - (minutoInicial - minutoFinal);
                duracaoHora -= 1;
            }
            else
            {
                duracaoMinuto = 0;
            }

            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
        }
    }
}