using System;

namespace VariasNotasComValidacao
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
            int confirmacao = 1;
            while (confirmacao == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 > 10 || nota1 < 0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }
                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 > 10 || nota2 < 0)
                {
                    Console.WriteLine("nota invalida");
                    nota2= double.Parse(Console.ReadLine());

                }

                double media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:F2}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                confirmacao = int.Parse(Console.ReadLine());

                while (confirmacao != 1 && confirmacao !=2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    confirmacao = int.Parse(Console.ReadLine());


                }
            }
            
            
        }
    }
}