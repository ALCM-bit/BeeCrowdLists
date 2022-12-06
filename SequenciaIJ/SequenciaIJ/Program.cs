using System;
using System.Linq;

namespace SequenciaIJ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 60;
            int i = 1;

            while (j > 0) 
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;

                
            }
            
            Console.WriteLine($"I=37 J=0");

            


        }
    }
}