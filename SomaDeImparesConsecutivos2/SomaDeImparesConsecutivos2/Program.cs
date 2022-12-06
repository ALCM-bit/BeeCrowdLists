using System;
using System.Linq;
using System.Linq.Expressions;

namespace SomaDeImparesConsecutivos2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //int[] valores = new int[] {}
            int loop = int.Parse(Console.ReadLine());
            int[] respostas = new int[loop];

            for (int i = 0; i < loop; i++)
            {
                string entradaXY = Console.ReadLine();
                int[] valores = entradaXY.Split(' ').Select(x => int.Parse(x)).ToArray();

                int soma = 0;

                if (valores[1] > valores[0])
                {
                    for (int j = valores[0] + 1; j < valores[1]; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }

                    }

                }
                else
                {
                    for (int j = valores[1] + 1; j < valores[0]; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }

                    }

                }
                respostas[i] = soma;
            }

            for(int i = 0; i < loop; i++)
            {
                Console.WriteLine(respostas[i]);

            }

        }
    }
}