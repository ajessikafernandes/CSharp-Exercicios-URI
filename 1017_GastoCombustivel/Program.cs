using System;

namespace _1017_GastoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas, km, combustivel;

            horas = double.Parse(Console.ReadLine());
            km = double.Parse(Console.ReadLine());

            combustivel = (km * horas) / 12;

            Console.WriteLine($"{combustivel:F3}");
            Console.ReadLine();
        }
    }
}
