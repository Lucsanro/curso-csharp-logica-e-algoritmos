using System;

namespace ExercicioBeecrowd1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int DDD = int.Parse(Console.ReadLine());
            string destino;

            switch (DDD)
            {
                case 61:
                    destino = "Brasilia";
                    break;
                case 71:
                    destino = "Salvador";
                    break;
                case 11:
                    destino = "Sao Paulo";
                    break;
                case 21:
                    destino = "Rio de Janeiro";
                    break;
                case 32:
                    destino = "Juiz de Fora";
                    break;
                case 19:
                    destino = "Campinas";
                    break;
                case 27:
                    destino = "Vitoria";
                    break;
                case 31:
                    destino = "Belo Horizonte";
                    break;
                default:
                    destino = "DDD nao cadastrado";
                    break;
            }

            Console.WriteLine(destino);
        }
    }
}