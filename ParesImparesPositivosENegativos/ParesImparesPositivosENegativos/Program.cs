using System;
namespace ParesImparesPositivosENegativos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pares = 0;
            int impares = 0;
            int negativos = 0;
            int positivos = 0;
            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                

                if (numero % 2 == 0)
                {
                    pares++;

                }
                else if (numero % 2 != 0)
                {
                    impares++;

                }

                if (numero < 0)
                {
                    negativos++;

                }
                else if (numero > 0)
                {
                    positivos++;

                }

            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");

        }
    }
}