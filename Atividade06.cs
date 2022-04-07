using System;

namespace atividades
{
    public class ex06
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE A MÉDIA GEOMÉTRICA ENTRE DOIS VALORES

            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            double mediaGeometrica = Math.Sqrt(primeiroValor * segundoValor);
            Console.WriteLine($"A média geométrica dos dois valores é {mediaGeometrica}");
        }
    }
}
