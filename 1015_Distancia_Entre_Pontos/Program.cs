using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015_Distancia_Entre_Pontos
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, y1, x2, y2, distancia;

            string[] linha = Console.ReadLine().Split(' ');
            x1 = double.Parse(linha[0]);
            y1 = double.Parse(linha[1]);

            string[] linha2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(linha2[0]);
            y2 = double.Parse(linha2[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{distancia:F4}");

        }
    }
}
