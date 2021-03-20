using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = 100;
            double km = 1000;
            double metros;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("Medidas");
            Console.WriteLine("-------");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Entre com a medida em metros: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            metros = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("---Equivalente---");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Metros para centímetros: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{metros * cm}cm");
            Console.Write("\n");
            Console.ResetColor();

            Console.Write("Metros para quilômetros: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{metros / km}Km");
            Console.ResetColor();
            Console.WriteLine();








        }
    }
}
