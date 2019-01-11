using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006_Media2
{
    class Media2
    {
        static void Main(string[] args)
        {

            double A, B, C, MEDIA; 

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine($"MEDIA = {MEDIA:F1}");

            Console.ReadLine();

        }
    }
}
