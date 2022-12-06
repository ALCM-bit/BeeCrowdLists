using System;
namespace QuadradoDePares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");

                }

            }
        }
    }
}