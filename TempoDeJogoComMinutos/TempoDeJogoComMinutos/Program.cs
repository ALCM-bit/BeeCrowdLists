using System;

namespace TempoDeJogoComMinutos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            int inicio = int.Parse(valores[0]);
            int inicioMinutos = int.Parse(valores[1]);

            int final = int.Parse(valores[2]);
            int finalMinutos = int.Parse(valores[3]);

           

            finalMinutos = finalMinutos + (final * 60);
            inicioMinutos = inicioMinutos +  (inicio * 60);

            int tempoTotal = finalMinutos - inicioMinutos;

            int hora = tempoTotal / 60;
            int minutos = tempoTotal % 60;

            if (tempoTotal <= 0)
            {
                tempoTotal = tempoTotal + (24 * 60);

                hora = tempoTotal/ 60;
                minutos = tempoTotal % 60;

                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minutos} MINUTO(S)");

            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minutos} MINUTO(S)");

            }
            

        }
    }
}