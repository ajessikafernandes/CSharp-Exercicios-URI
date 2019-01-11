using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio, pi = 3.14159, volume;

            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4 / 3.0) * pi * (raio * raio * raio);

            Console.WriteLine($"VOLUME = {volume:F3}");

        }
    }
}
