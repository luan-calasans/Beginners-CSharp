using System;

namespace atividades
{
    public class ex09
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CONVERTA GRAUS CELSIUS EM FAHRENHEIT

            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}Cº são {fahrenheit} fahrenheit");
        }
    }
}
