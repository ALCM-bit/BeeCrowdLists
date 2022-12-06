using System;

namespace PositivosEMedia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] valores = new double[6];
            int positivos = 0;
            double soma = 0.0;
            double media = 0.0;

            for (int i = 0; i < 6; i++)
            {
                valores[i] = double.Parse(Console.ReadLine());
                if (valores[i] >= 0)
                {
                    positivos++;
                    soma += valores[i];
                }

            }

            media = soma / positivos;

            Console.WriteLine($"{positivos} valores positivos");
            Console.WriteLine($"{media:F1}");

        }
    }
}