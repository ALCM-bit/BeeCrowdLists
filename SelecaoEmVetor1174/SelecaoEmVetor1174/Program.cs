using System;

namespace SelecaoEmVetor1174
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] valores = new double[100];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = double.Parse(Console.ReadLine());

                if (valores[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {valores[i]:F1}");
                }

            }
        }
    }
}