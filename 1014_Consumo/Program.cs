using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {

            float X, Y, Z;

            X = float.Parse(Console.ReadLine());
            Y = float.Parse(Console.ReadLine());
            Z = X / Y;

            Console.WriteLine($"{Z:F3} km/l");

        }
    }
}
