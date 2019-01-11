using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005_Media1
{
    class Media
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
            
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);
            Console.WriteLine($"MEDIA = {MEDIA:F5}");
            
            Console.ReadLine();
        }
    }
}
