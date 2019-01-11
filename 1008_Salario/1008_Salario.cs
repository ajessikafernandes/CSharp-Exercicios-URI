using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008_Salario
{
    class Salario
    {
        static void Main(string[] args)
        {
            int numeroFunc, totalHoras;
            double recebePorHora, salario;

            numeroFunc = int.Parse(Console.ReadLine());
            totalHoras = int.Parse(Console.ReadLine());

            recebePorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = totalHoras * recebePorHora;

            Console.WriteLine("NUMBER = " + numeroFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
       
        }
    }
}
