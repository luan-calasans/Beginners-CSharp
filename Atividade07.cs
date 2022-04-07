using System;

namespace atividades
{
    public class ex07
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CONVERTA MILHAS MARÍTIMAS EM QUILÔMETROS

            Console.Write("Digite a quantidade em milhas marítimas: ");
            double milhasMaritimas = double.Parse(Console.ReadLine());

            double quilometros = (milhasMaritimas * 1852) / 1000;

            Console.WriteLine($"{milhasMaritimas} milhas marítimas são {quilometros}km");
        }
    }
}
