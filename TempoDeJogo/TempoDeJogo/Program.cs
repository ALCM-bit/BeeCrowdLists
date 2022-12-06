using System;

namespace TempoDeJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            int inicio = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);
            int total = 0;

            if (inicio > final)
            {
                total = (24 - (inicio - final));

                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            else if (inicio < final)
            {
                total = (final - inicio);

                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
            }

        }
    }
}