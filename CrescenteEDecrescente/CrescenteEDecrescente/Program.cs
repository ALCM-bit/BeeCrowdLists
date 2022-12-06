using System;
using System.Linq;
using System.Collections.Generic;

namespace CrescenteEDecrescente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorX = 0;
            int valorY = 1;

            List<String> resultados = new List<String>();
            do
            {
                String entrada = Console.ReadLine();
                valorX = int.Parse(entrada.Split(' ')[0]);
                valorY = int.Parse(entrada.Split(' ')[1]);

                if (valorX > valorY)
                {
                    String resposta = "Decrescente";
                    resultados.Add(resposta);
                    
                }
                else if (valorX < valorY)
                {
                    String resposta = "Crescente";
                    resultados.Add(resposta);
                }
                
            } while (valorX != valorY);

            String[] respostas= resultados.ToArray();

            for (int i = 0; i < respostas.Length; i++)
            {
                Console.WriteLine(respostas[i]);

            }

        }
    }
}