using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009_Salario_com_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double salario, totalVendas, total;

            nome = Console.ReadLine();
            salario = Convert.ToDouble(Console.ReadLine());
            totalVendas = Convert.ToDouble(Console.ReadLine());

            total = salario + (15 * totalVendas) / 100;

            Console.WriteLine($"TOTAL = R$ {total:F2}");

        }
    }
}
