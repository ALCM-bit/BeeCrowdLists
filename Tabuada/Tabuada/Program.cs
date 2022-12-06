using System;

namespace Tabuada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int multiplicacao = i * entrada;
                Console.WriteLine($"{i} x {entrada} = {multiplicacao}");

            }
        }
    }
}