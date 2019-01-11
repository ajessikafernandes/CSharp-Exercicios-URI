using System;

namespace _1018_Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ,b;

            a = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine($"{a / 100} nota(s) de R$ 100,00");
            b = (a % 100);
            Console.WriteLine($"{b / 50} nota(s) de R$ 50,00");
            b = (b % 50);
            Console.WriteLine($"{b / 20} nota(s) de R$ 20,00");
            b = (b % 20);
            Console.WriteLine($"{b / 10} nota(s) de R$ 10,00");
            b = (b % 10);
            Console.WriteLine($"{b / 5} nota(s) de R$ 5,00");
            b = (b % 5);
            Console.WriteLine($"{b / 2} nota(s) de R$ 2,00");
            b = (b % 2);
            Console.WriteLine($"{b / 1} nota(s) de R$ 1,00");
            b = (b % 1);
            Console.ReadLine();
     
        }
    }
}
