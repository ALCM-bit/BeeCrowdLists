using System;

namespace QuadradoEAoCubo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entradaN; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");

            }
        }
    }
}