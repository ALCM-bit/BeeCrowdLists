internal class Program
{
    private static void Main(string[] args)
    {
        int pago = int.Parse(Console.ReadLine());

        int cem = pago / 100;
        int cinquenta = (pago - (100 * cem)) / 50;
        int vinte = (pago - (100 * cem) - (50 * cinquenta)) / 20;
        int dez = (pago - (100 * cem) - (50 * cinquenta) - (20 * vinte)) / 10;
        int cinco = (pago - (100 * cem) - (50 * cinquenta) - (20 * vinte) - (10 * dez)) / 5;
        int dois = (pago - (100 * cem) - (50 * cinquenta) - (20 * vinte) - (10 * dez) - (5 * cinco)) / 2;
        int um = (pago - (100 * cem) - (50 * cinquenta) - (20 * vinte) - (10 * dez) - (5 * cinco) - (2 * dois)) / 1;

        Console.WriteLine(pago);
        Console.WriteLine($"{cem} nota(s) de R$ 100,00");
        Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
        Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
        Console.WriteLine($"{dez} nota(s) de R$ 10,00");
        Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
        Console.WriteLine($"{dois} nota(s) de R$ 2,00");
        Console.WriteLine($"{um} nota(s) de R$ 1,00");

    }
}