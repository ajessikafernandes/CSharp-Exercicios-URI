using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010_CalculoSimples
{
    class CalculoSimples
    {
        static void Main(string[] args)
        {
           
            double valorTotal;

            string[] linha1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(linha1[0]);
            int numeroPeca1 = int.Parse(linha1[1]);
            double valorUnitario1 = Convert.ToDouble(linha1[2]);

            string[] linha2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(linha2[0]);
            int numeroPeca2 = int.Parse(linha2[1]);
            double valorUnitario2 = Convert.ToDouble(linha2[2]);

            valorTotal = (valorUnitario1 * numeroPeca1) + (valorUnitario2 * numeroPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
       
            Console.ReadLine();
        }
    }
}
