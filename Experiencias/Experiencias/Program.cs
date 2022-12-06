using System;
using System.Linq;

namespace Experiencias
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int coelhos = 0;
            int serpentes = 0;
            int ratos = 0;
            int total = 0;
            double percentual = 0.0;

            
            for (int i = 0; i < loop; i++)
            {
                String entrada = Console.ReadLine();
                int valor = int.Parse(entrada.Split(' ')[0]);
                String tipo = entrada.Split(' ')[1];

                    
                total += valor;
                    
                    
                    if (tipo == "C")
                    {
                        
                      coelhos = coelhos + valor;

                    }
                    else if (tipo == "R")
                    {
                      ratos = ratos + valor;

                    }
                    else if (tipo == "S")
                    {
                      serpentes = serpentes + valor;

                    }
           
                }

            
                total = coelhos + ratos + serpentes;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {serpentes}");
            Console.WriteLine($"Percentual de coelhos: {percentual =(coelhos * 100.0)/total:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentual = (ratos * 100.0) / total:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentual = (serpentes * 100.0) / total:F2} %");
        }
    }
}