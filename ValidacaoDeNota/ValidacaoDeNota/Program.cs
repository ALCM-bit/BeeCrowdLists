using System;

namespace ValidacaoDeNota
{
    public class Program
    {
        static bool isValid(double nota)
        {
            if (nota < 0.0 || nota > 10.0)
            {
                Console.WriteLine("nota invalida");
                return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            double nota1 = 0.0;
            double nota2 = 0.0;

            do
            {
                nota1 = double.Parse(Console.ReadLine());
                
            } while (!isValid(nota1));

            do
            {
                nota2 = double.Parse(Console.ReadLine());

            } while (!isValid(nota2));

            double media = (nota1 + nota2) / 2;

            Console.WriteLine($"media = {media:F2}");

        }
    }
}