using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1016_Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, minutos;

            km = int.Parse(Console.ReadLine());
            minutos = km * 2;

            Console.WriteLine($"{minutos} minutos");
            Console.ReadLine();

        }
    }
}
