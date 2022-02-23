using System;
namespace MeuNamespace
{
    public class MinhaAplicacao
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE A ÁREA DO QUADRADO

            Console.Write("Digite o lado: ");
            double lado = double.Parse(Console.ReadLine());
            
            double resultado = lado * lado;
            
            Console.WriteLine($"O resultado foi {resultado}");
        }
    }
}
