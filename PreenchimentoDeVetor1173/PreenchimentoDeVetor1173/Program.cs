using System;

namespace PreenchimentoDeVetor1173
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorInteiros = new int[10];


            vetorInteiros[0] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"N[{i}] = {vetorInteiros[i]}");
                }
                else
                {
                    vetorInteiros[i] = vetorInteiros[i - 1] + vetorInteiros[i - 1];
                    Console.WriteLine($"N[{i}] = {vetorInteiros[i]}");
                }
                
            }
        }
    }
   
}