internal class Program
{
    private static void Main(string[] args)
    {
        int totalSegundos = int.Parse(Console.ReadLine());

        int horas = totalSegundos / 3600;
        totalSegundos = totalSegundos - horas * 3600;
        int minutos = totalSegundos / 60;
        totalSegundos = totalSegundos - minutos * 60;
        
        Console.WriteLine($"{horas}:{minutos}:{totalSegundos}");
        
    }
}