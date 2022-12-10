using System;
using System.Linq;

namespace TrocaEmVetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorInteiros = new int[20];

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                vetorInteiros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {vetorInteiros[19 - i]}");

            }

        }
    }
}