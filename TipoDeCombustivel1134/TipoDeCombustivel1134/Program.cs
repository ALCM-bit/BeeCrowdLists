using System;

namespace TipodeCombustivel1134
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            do
            {
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    alcool++;

                }
                else if (option == 2)
                {
                    gasolina++;

                }
                else if (option == 3)
                {
                    diesel++;

                }


            } while (option!= 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}