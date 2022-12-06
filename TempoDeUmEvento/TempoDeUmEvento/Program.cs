using System;

namespace TempoDeUmEvento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            int diaInicial = int.Parse(entrada.Split()[1]);
            string[] entradaInicial = Console.ReadLine().Split(':');
            int horaInicial = int.Parse(entradaInicial[0]);
            int minutoInicial = int.Parse(entradaInicial[1]);
            int segundoInicial = int.Parse(entradaInicial[2]);

            string entrada2 = Console.ReadLine();
            int diaFinal = int.Parse(entrada2.Split()[1]);
            string[] entradaFinal = Console.ReadLine().Split(':');
            int horaFinal = int.Parse(entradaFinal[0]);
            int minutoFinal = int.Parse(entradaFinal[1]);
            int segundoFinal = int.Parse(entradaFinal[2]);

            int segundos = segundoFinal - segundoInicial;
            int minutos = minutoFinal - minutoInicial;
            int horas = horaFinal - horaInicial;
            int dia = diaFinal - diaInicial;

            if (segundos < 0)
            {
                segundos += 60;
                minutos--;

            }
            if (minutos < 0)
            {
                minutos += 60;
                horas--;
            }
            if (horas < 0)
            {
                horas += 24;
                dia--;

            }

            Console.WriteLine($"{dia} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");



        }
    }
}