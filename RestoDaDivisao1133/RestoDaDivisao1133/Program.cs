using System;

namespace RestoDaDivisao1133
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            if (valor1 > valor2)
            {
                for (int i = valor2; i < valor1; i++)
                {
                    int resto = i % 5;

                    if (resto == 2 || resto == 3)
                    {
                        if(i != 2)
                        {
                            Console.WriteLine(i);

                        }
                        

                    }

                }

            }
            else
            {
                for (int i = valor1; i < valor2; i++)
                {
                    int resto = i % 5;

                    if (resto == 2 || resto == 3)
                    {
                        if (i != 2)
                        {
                            Console.WriteLine(i);

                        }

                    }

                }

            }
        }
    }
}