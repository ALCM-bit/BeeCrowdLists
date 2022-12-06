using System;
namespace TiposDeTriangulos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            Double[] valoresTriangulo = new Double[] { double.Parse(valores[0]), double.Parse(valores[1]), double.Parse(valores[2])};

            

            double a, b, c, x = 0.0;
            a = valoresTriangulo[0];
            b = valoresTriangulo[1];
            c = valoresTriangulo[2];

            if (a < b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (b < c)
            {
                x = b;
                b = c;
                c = x;
            }
            if (a < b)
            {
                x = a;
                a = b;
                b = x;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && a==c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a==b || a==c || b==c || b==a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }


        }
    }
}