using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_URI
{
    class Soma_area_retangulo
    {
        static void Main(string[] args)
        {
            double area, n, raio;
          
            n = 3.14159;
            raio = Convert.ToDouble(Console.ReadLine());
            area = n * Math.Pow(raio, 2);

            //Formatando a string  
            Console.WriteLine($"A={area:F4}");
            Console.ReadLine();

        }
    }
}
