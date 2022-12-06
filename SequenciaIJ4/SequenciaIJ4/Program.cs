using System;
using System.Globalization;
using System.Linq;

namespace Sequencia4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double i = 0.0;
            double j = 0.0;
            int y = 0;

            while (y != 10)
            {
                if (i == 2 || i == 0 || i == 1 || i == 2.0)
                {
                    Console.WriteLine($"I={i:F0} J={j + 1:F0}");
                    Console.WriteLine($"I={i:F0} J={j + 2:F0}");
                    Console.WriteLine($"I={i:F0} J={j + 3:F0}");

                }
                else
                {
                    Console.WriteLine($"I={i:F1} J={j + 1:F1}");
                    Console.WriteLine($"I={i:F1} J={j + 2:F1}");
                    Console.WriteLine($"I={i:F1} J={j + 3:F1}");

                }
                
                i += 0.20;
                j += 0.20;

                y += 1;
            }
            Console.WriteLine($"I=2 J=3");
            Console.WriteLine($"I=2 J=4");
            Console.WriteLine($"I=2 J=5");

        }
    }
}