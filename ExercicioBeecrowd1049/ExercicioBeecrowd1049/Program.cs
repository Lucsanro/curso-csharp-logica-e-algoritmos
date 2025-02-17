using System;

namespace ExercicioBeecrowd1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string esquema1, esquema2, esquema3, animal;

            esquema1 = Console.ReadLine();
            esquema2 = Console.ReadLine();
            esquema3 = Console.ReadLine();

            if (esquema1 == "vertebrado")
            {
                if (esquema2 == "ave")
                {
                    if (esquema3 == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else
                    {
                        animal = "pomba";
                    }
                }
                else
                {
                    if (esquema3 == "onivoro")
                    {
                        animal = "homem";
                    }
                    else
                    {
                        animal = "vaca";
                    }
                }
            }
            else
            {
                if (esquema2 == "inseto")
                {
                    if (esquema3 == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else
                    {
                        animal = "lagarta";
                    }
                }
                else
                {
                    if (esquema3 == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);
        }
    }
}