using System;

namespace SeisNumerosImpares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int impar = int.Parse(Console.ReadLine());
            int cont = 0;

            while(cont<6)
            {
                
                if (impar % 2 != 0)
                {
                    cont++;
                    Console.WriteLine(impar);

                }
                impar++;

            }
        }
    }
}