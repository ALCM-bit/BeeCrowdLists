using System;
namespace NumerosPares
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int numero = 0;

            for (int i = 0; i < 100; i++)
            {
                numero = numero + 1;

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);

                }

            }
        }
    }
}