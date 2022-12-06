using System;

namespace Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String entrada = Console.ReadLine();

            if (entrada == "vertebrado")
            {
                entrada= Console.ReadLine();
                if (entrada == "ave")
                {
                    entrada = Console.ReadLine();
                    if(entrada == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (entrada == "onivoro")
                    {
                        Console.WriteLine("pomba");

                    }

                }
                else if (entrada == "mamifero")
                {
                    entrada = Console.ReadLine();
                    if (entrada == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (entrada == "herbivoro")
                    {
                        Console.WriteLine("vaca");

                    }

                }

            }
            else if (entrada == "invertebrado")
            {
                entrada = Console.ReadLine();
                if (entrada == "inseto")
                {
                    entrada = Console.ReadLine();
                    if (entrada == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (entrada == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }

                }
                else if (entrada == "anelideo")
                {
                    entrada = Console.ReadLine();
                    if (entrada == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (entrada == "onivoro")
                    {
                        Console.WriteLine("minhoca");

                    }

                }

            }

        }
    }
}