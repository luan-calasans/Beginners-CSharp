using System;

namespace atividades
{
    public class ex01
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE A ÁREA DO RETÂNGULO

            Console.Write("Digite a base do retângulo: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a altura do retângulo: ");
            double a = double.Parse(Console.ReadLine());
            
            double resultado = a * b;
            
            Console.WriteLine($"A área do retângulo é {resultado}");
        }
    }
}
