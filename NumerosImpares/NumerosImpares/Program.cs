using System;

namespace NumerosImpares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int impar = int.Parse(Console.ReadLine());

            for (int i = 0; i <= impar; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}