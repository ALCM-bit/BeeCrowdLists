internal class Program
{
    private static void Main(string[] args)
    {
        String[] conta = Console.ReadLine().Split(' ');
        int idPedido = int.Parse(conta[0]);
        int quantidade = int.Parse(conta[1]);
        double totalPagar = 0;

        if (idPedido == 1)
        {
            totalPagar = 4.00 * quantidade;
        }
        else if (idPedido == 2)
        {
            totalPagar = 4.50 * quantidade;
        }
        else if (idPedido == 3)
        {
            totalPagar = 5.00 * quantidade;
        }
        else if (idPedido == 4)
        {
            totalPagar = 2.00 * quantidade;
        }
        else if (idPedido == 5)
        {
            totalPagar = 1.50 * quantidade;
        }

        Console.WriteLine($"Total: R$ {totalPagar:F2}");

    }
}