using System;
using System.Globalization;

namespace ExercicioBeecrowd1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int calculoNotas = (int) (N * 100.0 + 0.5) ;
            /*
             resolução deste trecho na solução do professor:
            https://github.com/acenelio/curso-logica-de-programacao-csharp/blob/master/uri1021/uri1021/Program.cs
             */

            Console.WriteLine("NOTAS:");
            int nota = 100;
            double quociente = (int) calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            nota = 50;
            quociente = (int)calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            nota = 20;
            quociente = (int)calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            nota = 10;
            quociente = (int)calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            nota = 5;
            quociente = (int)calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            nota = 2;
            quociente = (int)calculoNotas / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            calculoNotas = calculoNotas % (nota * 100);

            Console.WriteLine("MOEDAS:");
            int calculoMoedas = calculoNotas;

            int moeda = 100;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            calculoMoedas = calculoMoedas % moeda;
            

            moeda = 50;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            calculoMoedas = calculoMoedas % moeda;

            moeda = 25;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            calculoMoedas = calculoMoedas % moeda;

            moeda = 10;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            calculoMoedas = calculoMoedas % moeda;

            moeda = 5;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            calculoMoedas = calculoMoedas % moeda;

            moeda = 1;
            quociente = (double)calculoMoedas / moeda;
            quociente = (int)quociente;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
            calculoMoedas = calculoMoedas % moeda;


        }
    }
}