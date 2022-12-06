using System;
namespace DDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dDD = int.Parse(Console.ReadLine());

            if (dDD == 61)
            {
                Console.WriteLine("Brasilia");

            }
            else if (dDD == 71)
            {
                Console.WriteLine("Salvador");

            }
            else if (dDD == 11)
            {
                Console.WriteLine("Sao Paulo");

            }
            else if (dDD == 21)
            {
                Console.WriteLine("Rio de Janeiro");

            }
            else if (dDD == 32)
            {
                Console.WriteLine("Juiz de Fora");

            }
            else if (dDD == 19)
            {
                Console.WriteLine("Campinas");

            }
            else if (dDD == 27)
            {
                Console.WriteLine("Vitoria");

            }
            else if (dDD == 31)
            {
                Console.WriteLine("Belo Horizonte");

            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}