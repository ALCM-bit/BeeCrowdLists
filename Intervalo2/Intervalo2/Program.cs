using System;

namespace Intervalo2
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int loop = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0; 

            for (int i = 0; i < loop; i++)
            {
                int digitado = int.Parse(Console.ReadLine());
                if (digitado >= 10 && digitado <=20)
                {
                    dentro++;


                }
                else
                {
                    fora++;
                }

            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}