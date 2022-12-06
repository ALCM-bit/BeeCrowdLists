using System;
using System.Linq;

namespace MaiorEPosicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = entrada;
                    posicao = i;

                }
                else if (entrada > maior)
                {
                    maior = entrada;
                    posicao = i;
                }

            }
            Console.WriteLine($"{maior}");
            Console.WriteLine($"{posicao}");

        }
    }
}