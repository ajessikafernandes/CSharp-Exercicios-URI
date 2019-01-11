using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013_O_Maior
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            string[] linha = Console.ReadLine().Split(' ');
            a = int.Parse(linha[0]);
            b = int.Parse(linha[1]);
            c = int.Parse(linha[2]);

            int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            int MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine($"{MaiorABC} eh o maior");

        }
    }
}
