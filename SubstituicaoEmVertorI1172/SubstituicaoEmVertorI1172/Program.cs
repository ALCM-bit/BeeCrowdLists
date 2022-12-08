using System;

namespace SubstituicaoEmVertorI1172
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorDeInteiros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetorDeInteiros[i] = int.Parse(Console.ReadLine());

                if (vetorDeInteiros[i] <= 0)
                {
                    vetorDeInteiros[i] = 1;
                }
            }

            for(int i = 0; i < vetorDeInteiros.Length; i++)
            {
                Console.WriteLine($"X[{i}] = {vetorDeInteiros[i]}");
            }
        }
    }
}