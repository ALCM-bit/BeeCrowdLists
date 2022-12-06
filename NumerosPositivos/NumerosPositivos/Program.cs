using System;

namespace NumerosPositivos
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            const int voltas = 6;
            int cont = 0;
            for (int i = 0; i  < voltas; i++ )
            {
                double digitado = double.Parse(Console.ReadLine());

                if (digitado >= 0)
                {
                    cont++;

                }

            }
            Console.WriteLine($"{cont} valores positivos");
        }
    }
}