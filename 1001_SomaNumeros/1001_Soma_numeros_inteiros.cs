using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_URI
{
    class Program
    {
       static void Main(string[] args)
        {
            //Declarando as variaveis
            int a, b, x;
           
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a + b;

            Console.WriteLine("X = " + x);
            Console.ReadLine();

        }
    }
}
