using System;

namespace atividades
{
    public class ex05
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE A MÉDIA ARITMÉTICA ENTRE QUATRO VALORES

            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double terceiroValor = double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            double quartoValor = double.Parse(Console.ReadLine());
            double mediaAritmetica = (primeiroValor + segundoValor + terceiroValor + quartoValor) / 4;

            Console.WriteLine($"A média aritmética dos quatro valores é {mediaAritmetica}");
        }
    }
}
