using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace FibonacciEmVetor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            long[] fibonacci = new long[61];

            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                int posicao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fib({posicao}) = {fibonacci[posicao]}");

            }
        }
    }
}