using System;
using System.Globalization;

namespace PreenchimentoDeVetor_II1177
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorInteiros = new int[1000];
            int valorEntrada = int.Parse(Console.ReadLine());

            for (int i = 0, j = 0; i < vetorInteiros.Length && j <= valorEntrada; i++, j++)
            {
                if (j == valorEntrada && i != 1000)
                {
                    j = 0;
                    vetorInteiros[i] = j;
                    Console.WriteLine($"N[{i}] = {vetorInteiros[i]}");
                }
                else 
                {
                    vetorInteiros[i] = j;
                    Console.WriteLine($"N[{i}] = {vetorInteiros[i]}");
                }
                
            }
        }
    }
}