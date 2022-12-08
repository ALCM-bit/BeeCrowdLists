using System;

namespace SequenciaLogica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());
            entradaN = entradaN;


            for (int i = 1; i <= entradaN; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
                Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}");


            }
        }
    }
}