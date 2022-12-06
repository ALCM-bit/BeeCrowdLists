using System;

namespace Questao1040
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] notas = Console.ReadLine().Split(' ');
            double N1 = double.Parse(notas[0]);
            double N2 = double.Parse(notas[1]);
            double N3 = double.Parse(notas[2]);
            double N4 = double.Parse(notas[3]);

            double totalPesos = 2 + 3 + 4 + 1;

            double media = Math.Truncate((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / totalPesos;


            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno aprovado.");

            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno reprovado.");

            }
            else if (media >= 5.0 && media <= 6.9)
            {

                double exame = double.Parse(Console.ReadLine());

                double mediaExame = (exame + media) / 2;

                if (mediaExame >= 5.0)
                {
                    Console.WriteLine($"Media: {media:F1}");
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine($"Nota do exame: {exame:F1}");
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");


                }
                else if (mediaExame <= 4.9)
                {
                    Console.WriteLine($"Media: {media:F1}");
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine($"Nota do exame: {exame:F1}");
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");
                }

            }

        }
    }
}