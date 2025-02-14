using System;

namespace ExercicioBeecrowd1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicial, horaInicial, minutoInicial, segundoInicial,
                diaFinal, horaFinal, minutoFinal, segundoFinal,
                calculoInicial, resto, calculoFinal, resultado;

            string[] vetor = Console.ReadLine().Split(' ');
            diaInicial = int.Parse(vetor[1]);

            vetor = Console.ReadLine().Split(':');
            horaInicial = int.Parse(vetor[0]);
            minutoInicial = int.Parse(vetor[1]);
            segundoInicial = int.Parse(vetor[2]);

            vetor = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(vetor[1]);
                       
            vetor = Console.ReadLine().Split(':');
            horaFinal = int.Parse(vetor[0]);
            minutoFinal = int.Parse(vetor[1]);
            segundoFinal = int.Parse(vetor[2]);

            calculoInicial = (diaInicial * 86400) + (horaInicial * 3600) + (minutoInicial * 60) + segundoInicial;

            calculoFinal = (diaFinal * 86400) + (horaFinal * 3600) + (minutoFinal * 60) + segundoFinal;

            resultado = calculoFinal - calculoInicial;

            int diaEvento = resultado / 86400;
            Console.WriteLine(diaEvento + " dia(s)");
            resto = resultado % 86400;

            int horaEvento = resto / 3600;
            Console.WriteLine(horaEvento + " hora(s)");
            resto = resto % 3600;

            int minutoEvento = resto / 60;
            Console.WriteLine(minutoEvento + " minuto(s)");
            resto = resto % 60;

            int segundoEvento = resto / 1;
            Console.WriteLine(segundoEvento + " segundo(s)");             

        }
    }
}