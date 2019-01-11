using System;

namespace _1020_IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, ano, mes, dia;

            total = int.Parse(Console.ReadLine());

            ano = total / 365;
            mes = (total % 365) / 30;
            dia = (total % 365) % 30;

            Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");

            Console.ReadLine();
            
        }
    }
}
