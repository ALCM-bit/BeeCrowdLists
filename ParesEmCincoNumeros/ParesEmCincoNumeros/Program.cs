using System;

namespace ParesEmCincoNumeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cont = 0;

            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    cont++;
                }

            }
            Console.WriteLine($"{cont} valores pares");
        }
    }
}