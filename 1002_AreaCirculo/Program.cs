using System;

namespace _1002_AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {

            double area, n, raio;

            n = 3.14159;
            raio = Convert.ToDouble(Console.ReadLine());
            area = n * Math.Pow(raio, 2);

            Console.WriteLine($"A={area:F4}");

        }
    }
}
