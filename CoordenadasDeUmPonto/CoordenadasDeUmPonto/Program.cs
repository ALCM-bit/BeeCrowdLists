using System;
namespace CoordenadasDeUmPonto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');

            double pontoX = double.Parse(valores[0]);
            double pontoY = double.Parse(valores[1]);

            if (pontoX > 0 && pontoY > 0)
            {
                Console.WriteLine("Q1");

            }
            else if (pontoX < 0 && pontoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (pontoX < 0 && pontoY < 0)
            {
                Console.WriteLine("Q3");

            }
            else if (pontoX > 0 && pontoY < 0)
            {
                Console.WriteLine("Q4");

            }
            else if (pontoX == 0 && pontoY == 0)
            {
                Console.WriteLine("Origem");

            }
            else if (pontoX == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (pontoY == 0)
            {
                Console.WriteLine("Eixo X");

            }

            

        }
    }
}
