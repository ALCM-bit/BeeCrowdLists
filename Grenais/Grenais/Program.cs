using System;

namespace Grenais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int resposta = 1;
            int grenais = 0;
            int pointsInter = 0;
            int pointsGremio = 0;
            int empate = 0;

            grenais++;
            while (resposta != 2)
            {
                
                String entrada = Console.ReadLine();
                int inter = Int32.Parse(entrada.Split(' ')[0]);
                int gremio = Int32.Parse(entrada.Split(' ')[1]);

                if (inter > gremio)
                {
                    pointsInter++;
                    break;
                }
                else if(gremio > inter)
                {
                    pointsGremio++;
                    break;
                }
                else
                {
                    empate++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                resposta = Int32.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    grenais++;
                    break;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{pointsInter}");
            Console.WriteLine($"Gremio:{pointsGremio}");
            Console.WriteLine($"Empates:{empate}");

            if (pointsInter > pointsGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (pointsGremio > pointsInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }

        }
    }
}