using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class ex27
    {
        static void Main(string[] args)
        {
            /*
             Desenvolva um programa que receba 3 números via teclado e no final exiba o maior.
             Ps: usar somente duas variáveis
             */
            int firstNumber = 0, secondNumber = 0;
            try
            {
                Console.Write("Digite o primeiro número: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                secondNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadLine();
                return;
            }
            if (firstNumber > secondNumber)
            {
                Console.Write("Digite o terceiro número: ");
                secondNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Digite o terceiro número: ");
                firstNumber = int.Parse(Console.ReadLine());
            }
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"O maior é {firstNumber}");
            }
            else
            {
                Console.WriteLine($"O maior é {secondNumber}");
            }
            Console.ReadKey();
        }
    }
}
