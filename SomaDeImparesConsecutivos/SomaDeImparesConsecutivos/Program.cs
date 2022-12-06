using System;
using System.Security.Cryptography.X509Certificates;

namespace SomaDeImparesConsecutivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            int total = 0;

            if (val1 < val2)
            {
                for (int i = val1 + 1; i < val2; i++)
                {
                    if (i % 2 != 0)
                    {
                        total += i;

                    }

                }

            }
            else
            {
                for (int i = val2 + 1; i < val1; i++)
                {
                    if (i % 2 != 0)
                    {
                        total += i;

                    }

                }

            }
            Console.WriteLine(total);
        }
    }
}