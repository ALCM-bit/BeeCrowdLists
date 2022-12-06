using System;

namespace ParOuImpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int[] valor= new int[loop];

            for (int i = 0; i < loop; i++)
            {
                valor[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < loop; i++)
            {
                if (valor[i] == 0)
                {
                    Console.WriteLine("NULL");

                }
                else if (valor[i] % 2 == 0)
                {
                    if (valor[i] < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");

                    }
                    else
                    {
                        Console.WriteLine("EVEN POSITIVE");

                    }

                }
                else if (valor[i] % 2 != 0)
                {
                    if (valor[i] < 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");

                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");

                    }

                }

            }
        }
    }
}