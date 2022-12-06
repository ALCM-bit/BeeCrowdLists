internal class Program
{
    private static void Main(string[] args)
    {
        String[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        // b^2 - 4ac

        double bhaskara = (Math.Pow(b, 2)) - ((4 * a) * c);

        if (bhaskara < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");

        }
        else
        {
            // -b +- rais de bhaskara / 2 * a

            double R2 = ((-b) - Math.Sqrt(bhaskara)) / (2 * a);
            double R1 = ((-b) + Math.Sqrt(bhaskara)) / (2 * a);

            Console.WriteLine($"R1 = {R1:F5}");
            Console.WriteLine($"R2 = {R2:F5}");

        }

    }
}