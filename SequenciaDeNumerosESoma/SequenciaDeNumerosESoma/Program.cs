using System;
using System.Linq;
using System.Collections.Generic;

namespace SequenciaDeNumerosESoma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int m = 1;
            int n = 1;
            int soma = 0;
            List<int> list = new List<int>();
            do
            {

                String entrada = Console.ReadLine();
                m = int.Parse(entrada.Split(' ')[0]);
                n = int.Parse(entrada.Split(' ')[1]);
                if (m != 0 && n != 0 && m > 0 && n > 0)
                {
                    list.Add(m);
                    list.Add(n);
                }
            } while (m != 0 && n != 0 && m > 0 && n > 0);

            int[] valores = list.ToArray();
            int tamanho = valores.Length;

            for (int i = 0; i < tamanho/2; i++)
            {

                if (valores[i * 2] > valores[i * 2 + 1])
                {
                    for (int j = valores[i*2 + 1]; j <= valores[i*2]; j++)
                    {
                        Console.Write($"{j} ");
                        soma += j;
                        

                    }
                    Console.Write($"Sum={soma}\n");
                    soma = 0;

                }
                else
                {
                    for (int j = valores[i*2]; j <= valores[i*2 + 1]; j++)
                    {
                        soma += j;
                        Console.Write($"{j} ");
                        
                    }
                    Console.Write($"Sum={soma}\n");
                    soma = 0;

                }
            }
        }
    }
}