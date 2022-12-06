using System;
namespace Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            double valorA = double.Parse(valores[0]);
            double valorB = double.Parse(valores[1]);
            double valorC = double.Parse(valores[2]);

            if (valorB - valorC < valorA && valorA < valorB + valorC)
            {
                if (valorA - valorC < valorB && valorB < valorA + valorC)
                {
                    if (valorA - valorB < valorC && valorC < valorA + valorB)
                    {
                        double perimetro = valorA + valorB + valorC;
                        Console.WriteLine($"Perimetro = {perimetro:F1}");

                    }

                }
                

            }
            else
            {
                double areaTrapezio = (0.5 * valorC) * (valorA + valorB);
                Console.WriteLine($"Area = {areaTrapezio:F1}");

            }

        }
    }
}
