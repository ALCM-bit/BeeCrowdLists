using System;
namespace AumentoDeSalario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salarioAtual = double.Parse(Console.ReadLine());
            double porcentagem = 0.0;
            int convertido = 0;
            double ganho = 0.0;

            if (salarioAtual > 0 && salarioAtual <= 400.00)
            {
                convertido = 15;
                porcentagem = 0.15;
                ganho = salarioAtual * porcentagem;
                salarioAtual += ganho;


            }
            else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                convertido = 12;
                porcentagem = 0.12;
                ganho = salarioAtual * porcentagem;
                salarioAtual += ganho;

            }
            else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                convertido = 10;
                porcentagem = 0.10;
                ganho = salarioAtual * porcentagem;
                salarioAtual += ganho;

            }
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                convertido = 7;
                porcentagem = 0.07;
                ganho = salarioAtual * porcentagem;
                salarioAtual += ganho;

            }
            else if (salarioAtual > 2000.00)
            {
                convertido = 4;
                porcentagem = 0.04;
                ganho = salarioAtual * porcentagem;
                salarioAtual += ganho;

            }

            Console.WriteLine($"Novo salario: {salarioAtual:F2}");
            Console.WriteLine($"Reajuste ganho: {ganho:F2}");
            Console.WriteLine($"Em percentual: {convertido} %");


        }
    }
}