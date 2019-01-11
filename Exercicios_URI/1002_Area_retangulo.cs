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
            int A, B, PROD;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;

            //Formatando a string  
            Console.WriteLine($"PROD = {PROD}");
            Console.ReadLine();

        }
    }
}
