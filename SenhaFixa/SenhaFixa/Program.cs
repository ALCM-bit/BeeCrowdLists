using System;
using System.Linq;
using System.Collections.Generic;

namespace CrescenteEDecrescente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int senha = 0;
            const int chave = 2002; 

            List<String> resultados = new List<String>();
            do
            {
                String entrada = Console.ReadLine();
                senha = int.Parse(entrada);

                if (senha == chave)
                {
                    String resposta = "Acesso Permitido";
                    resultados.Add(resposta);

                }
                else
                {
                    String resposta = "Senha Invalida";
                    resultados.Add(resposta);
                }

            } while (senha != chave);

            String[] respostas = resultados.ToArray();

            for (int i = 0; i < respostas.Length; i++)
            {
                Console.WriteLine(respostas[i]);

            }

        }
    }
}