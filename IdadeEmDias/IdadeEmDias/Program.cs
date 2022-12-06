internal class Program
{
    private static void Main(string[] args)
    {
        const int mesDias = 30;
        const int anoDias = 365;

        int dia = int.Parse(Console.ReadLine());

        int anos = dia / anoDias;
        dia = dia - (anos * anoDias);

        int meses = dia / mesDias;
        dia = dia - (meses * mesDias);

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dia} dia(s)");

        
    }
}