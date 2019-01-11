using System;
using System.Globalization;

namespace _1021_NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, n100, n50, n20, n10, n5, n2;
            double m100, m050, m025, m010, m005, m001;
            double resto100, resto50, resto20, resto10, resto5, resto2;
            double restom100, restom50, restom25, restom10, restom5;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            n100 = (int)valor / 100;
            resto100 = (double)valor % 100.00;
            n50 = (int)resto100 / 50;
            resto50 = (double)resto100 % 50.00;
            n20 = (int)resto50 / 20;
            resto20 = (double)resto50 % 20.00;
            n10 = (int)resto20 / 10;
            resto10 = (double)resto20 % 10.00;
            n5 = (int)resto10 / 5;
            resto5 = (double)resto10 % 5.0;
            n2 = (int)resto5 / 2;
            resto2 = (double)resto5 % 2.00;

            m100 = (int)resto2 / 1;
            restom100 = (double)resto2 % 1;
            m050 = (int)((double)restom100 / 0.5);
            restom50 = (double)restom100 % 0.50;
            m025 = (int)(restom50 / 0.25);
            restom25 = (double)restom50 % 0.25;
            m010 = (int)(restom25 / 0.10);
            restom10 = (double)restom25 % 0.10;
            m005 = (int)(restom10 / 0.05);
            restom5 = (double)restom10 % 0.05;
            m001 = (int)(restom5 / 0.01);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m001 + " moeda(s) de R$ 0.01");

            Console.ReadLine();
        }
    }
}
