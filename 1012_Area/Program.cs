using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            double triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            string[] linha1 = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(linha1[0]);
            double B = Convert.ToDouble(linha1[1]);
            double C = Convert.ToDouble(linha1[2]);

            triangulo = A * C / 2;
            circulo = C * C * pi;
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:f3}\nCIRCULO: {circulo:F3}\nTRAPEZIO: {trapezio:F3}\nQUADRADO: {quadrado:F3}\nRETANGULO: {retangulo:F3}");

        }
    }
}
