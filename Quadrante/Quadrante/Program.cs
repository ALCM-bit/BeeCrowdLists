using System;
using System.Linq;
using System.Collections.Generic;

namespace Quadrante
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

                if (valorX > 0 && valorY > 0)
                {
                    String resposta = "primeiro";
                    resultados.Add(resposta);

                }
                else if (valorX < 0 && valorY > 0)
                {
                    String resposta = "segundo";
                    resultados.Add(resposta);
                }
                else if (valorX < 0 && valorY < 0)
                {
                    String resposta = "terceiro";
                    resultados.Add(resposta);
                }
                else if (valorX > 0 && valorY < 0)
                {
                    String resposta = "quarto";
                    resultados.Add(resposta);
                }

            } while (valorX != 0 && valorY != 0);

            String[] respostas = resultados.ToArray();

            for (int i = 0; i < respostas.Length; i++)
            {
                Console.WriteLine(respostas[i]);

            }

        }
    }
}