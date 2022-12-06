using System;

namespace Resto2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % entrada == 2)
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}