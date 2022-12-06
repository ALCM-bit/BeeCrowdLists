using System;
namespace ImpostoDeRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double calc = 0.0;

            if (salario <= 2000.00 )
            {
                Console.WriteLine("Isento");

            }
            else if (salario <= 3000.00)
            {
                calc = (salario - 2000.00) * 0.08;
                Console.WriteLine($"R$ {calc:F2}");

            }
            else if (salario <= 4500.00)
            {
                calc = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
                Console.WriteLine($"R$ {calc:F2}");

            }
            else
            {
                calc = (1000.0 * 0.08) + (1500.0 * 0.18) + ((salario - 4500.0) * 0.28);
                Console.WriteLine($"R$ {calc:F2}");

            }

        }
    }
}