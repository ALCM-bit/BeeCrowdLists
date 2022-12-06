using System;
using System.Linq;

namespace MediasPonderadas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            double[] medias = new double[loop];

            for (int i = 0; i < loop; i++)
            {
                String entrada = Console.ReadLine();
                double[] valores = entrada.Split(' ').Select(x => double.Parse(x)).ToArray();

                medias[i] = ((valores[0] * 2.0) + (valores[1] * 3.0) + (valores[2] * 5.0))/10;

            }

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine($"{medias[i]:F1}");

            }
        }
    }
}