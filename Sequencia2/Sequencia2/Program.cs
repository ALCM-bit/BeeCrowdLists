using System;
using System.Linq;

namespace Sequencia2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int aux = 1;

            for (int i = 1; i <= 5; i++)
            {
                
                if (i == 1)
                {
                    aux = 1;
                    Console.WriteLine($"I={i} J=7");
                    Console.WriteLine($"I={i} J=6");
                    Console.WriteLine($"I={i} J=5");
                }
                else
                {
                    aux += 2;
                    Console.WriteLine($"I={aux} J=7");
                    Console.WriteLine($"I={aux} J=6");
                    Console.WriteLine($"I={aux} J=5");
                }
            }
        }
    }
}