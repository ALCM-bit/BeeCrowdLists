using System;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        double dado = double.Parse(Console.ReadLine());
        int trocoNotas = (int)dado;
        int trocoMoedas = (int)((dado - trocoNotas) * 100);
        
        int cem = trocoNotas / 100;
        trocoNotas = trocoNotas - (cem * 100);
        

        int cinquenta = trocoNotas / 50;
        trocoNotas = trocoNotas - (cinquenta * 50);

        int vinte = trocoNotas / 20;
        trocoNotas = trocoNotas - (vinte * 20);

        int dez = trocoNotas / 10;
        trocoNotas = trocoNotas - (dez * 10);

        int cinco = trocoNotas / 5;
        trocoNotas = trocoNotas - (cinco * 5);

        int dois = trocoNotas / 2;
        trocoNotas = trocoNotas - (dois * 2);

        int um = trocoNotas;

        int cinquentaM = trocoMoedas / 50;
        trocoMoedas = trocoMoedas - (cinquentaM * 50);

        int vinteECincoM = trocoMoedas / 25;
        trocoMoedas = trocoMoedas - (vinteECincoM * 25);

        int dezM = trocoMoedas / 10;
        trocoMoedas = trocoMoedas - (dezM * 10);

        int cincoM = trocoMoedas / 5;
        trocoMoedas = trocoMoedas - (cincoM * 5);

        int umM = trocoMoedas;



        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{cem} nota(s) de R$ 100.00");
        Console.WriteLine($"{cinquenta} nota(s) de R$ 50.00");
        Console.WriteLine($"{vinte} nota(s) de R$ 20.00");
        Console.WriteLine($"{dez} nota(s) de R$ 10.00");
        Console.WriteLine($"{cinco} nota(s) de R$ 5.00");
        Console.WriteLine($"{dois} nota(s) de R$ 2.00");
        

        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{um} moeda(s) de R$ 1.00");
        Console.WriteLine($"{cinquentaM} moeda(s) de R$ 0.50");
        Console.WriteLine($"{vinteECincoM} moeda(s) de R$ 0.25");
        Console.WriteLine($"{dezM} moeda(s) de R$ 0.10");
        Console.WriteLine($"{cincoM} moeda(s) de R$ 0.05");
        Console.WriteLine($"{umM} moeda(s) de R$ 0.01");
        

        
    }
}