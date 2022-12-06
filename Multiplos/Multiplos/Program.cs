using System;
namespace Multiplos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            int inteiroA = int.Parse(valores[0]);
            int inteiroB = int.Parse(valores[1]);

            if (inteiroA % inteiroB == 0 || inteiroB % inteiroA == 0)
            {
                Console.WriteLine("Sao Multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}