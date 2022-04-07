using System;

namespace atividades
{
    public class ex03
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE A ÁREA DO TRIÂNGULO ISÓSCELES

            Console.Write("Digite o valor do lado: ");
            double lado = double.Parse(Console.ReadLine());

            double resultado = (lado * lado) / 2;

            Console.WriteLine($"O resultado foi {resultado}");
        }
    }
}
