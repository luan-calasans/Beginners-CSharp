using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades
{
    internal class ex21
    {
        static void Main(string[] args)
        {
            // Calcular e exibir a área de um retângulo, a partir dos valores da
            // base e altura que serão digitados. Se a área for maior que 100, exibir
            // a mensagem “Terreno grande”, caso contrário,
            // exibir a mensagem “Terreno pequeno”.
            double baseRetangulo = 0, alturaRetangulo = 0, area = 0;
            try
            {
                Console.Write("Digite o valor da base do retângulo: ");
                baseRetangulo = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da altura do retângulo: ");
                alturaRetangulo = double.Parse(Console.ReadLine());
                area = baseRetangulo * alturaRetangulo;
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }

            if (area > 100)
            {
                Console.WriteLine($"A área do retângulo é: {area}");
                Console.WriteLine("Terreno Grande");
            }
            else
            {
                Console.WriteLine($"A área do retângulo é: {area}");
                Console.WriteLine("Terreno Pequeno");
            }
            Console.ReadKey();
        }
    }
}
