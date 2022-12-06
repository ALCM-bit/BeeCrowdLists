using System;
namespace SortSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);

            if (valor3 < valor1 && valor3 < valor2)
            {
                Console.WriteLine(valor3);
                if (valor2 < valor1)
                {
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor1);

                }
                else
                {
                    Console.WriteLine(valor1);
                    Console.WriteLine(valor2);
                }
            }
            else if (valor2 < valor3 && valor2 < valor1)
            {
                Console.WriteLine(valor2);

                if (valor1 < valor3)
                {
                    Console.WriteLine(valor1);
                    Console.WriteLine(valor3);

                }
                else
                {
                    Console.WriteLine(valor3);
                    Console.WriteLine(valor1);
                }

            }
            else if (valor1 < valor2 && valor1 < valor3)
            {
                Console.WriteLine(valor1);
                if (valor2 < valor3)
                {
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor3);

                }
                else
                {
                    Console.WriteLine(valor3);
                    Console.WriteLine(valor2);
                }

            }
            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);

        }


    }
}
