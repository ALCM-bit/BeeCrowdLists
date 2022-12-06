using System;
using System.Linq;

namespace Sequencia3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int aux = 1;
            int j = 5;

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

                    Console.WriteLine($"I={aux} J={j + 4}");
                    Console.WriteLine($"I={aux} J={j + 3}");
                    Console.WriteLine($"I={aux} J={j + 2}");
                    j = j + 2;
                }
            }
        }
    }
}