using System;
using System.Linq;
using System.Collections.Generic;

namespace DividindoXPorY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            double resultado =  0;

            List<double> list = new List<double>();

            for (int i = 0; i < loop; i++)
            {
                String entrada = Console.ReadLine();

                double x = double.Parse(entrada.Split(' ')[0]);
                double y = double.Parse(entrada.Split(' ')[1]);

                if ( y == 0)
                {

                    list.Add(-100.0);
                    

                }
                else
                {
                    resultado = x / y;
                    list.Add(resultado);
                }

            }

            double[] respostas= list.ToArray();

            for (int i = 0; i < loop; i++)
            {
                if (respostas[i] == -100.0)
                {
                    Console.WriteLine("divisao impossivel");

                }
                else
                {
                    Console.WriteLine($"{respostas[i]:F1}");
                }
                

            }
        }
    }
}