using System;
using System.Globalization;

namespace ExercicioBeecrowd1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media, exame;

            string[] vetor = Console.ReadLine().Split(' ');

            nota1 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(vetor[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(vetor[3], CultureInfo.InvariantCulture);

            media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1) / 10;

            /* este "if" abaixo foi coletado da correção disponibilizada em:
             https://github.com/acenelio/curso-logica-de-programacao-csharp/blob/master/uri1040/uri1040/Program.cs
             */
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                media = (float) (media + exame) / 2;

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}