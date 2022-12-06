using System;

namespace PUM11442
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());
            int aux = 1;

            for (int i = 0; i < entradaN; i++)
            {
                Console.WriteLine($"{aux} {aux + 1} {aux + 2} PUM");
                aux += 4;

            }
        }
    }
}