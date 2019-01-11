]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007_Diferenca
{
    class Diferenca
    {
        static void Main(string[] args)
        {

            int A, B, C, D, DIFERENCA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());
            DIFERENCA = ((A * B) - (C * D));
            Console.WriteLine(DIFERENCA);

            Console.ReadLine();

        }
    }
}
