using System;

namespace _1019_ConversaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, hora, minutos, segundos;

            n = int.Parse(Console.ReadLine());

            hora = n / 3600;
            minutos = (n % 3600) / 60;
            segundos = (n % 3600) % 60;

            Console.WriteLine($"{hora}:{minutos}:{segundos}");
 
            Console.ReadLine();
           
        }
    }
}
