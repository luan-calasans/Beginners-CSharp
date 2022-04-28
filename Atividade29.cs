using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex29
    {
        static void Main(string[] args)
        {
            /*
               Desenvolva um programa que receba três valores via teclado e no final exiba a soma. 
               Ps: utilizando somente duas variáveis
             */

            double userData = 0, sum = 0;
            try
            {
                Console.Write("Digite um número: ");
                userData = double.Parse(Console.ReadLine());
                sum += userData;

                Console.Write("Digite um número: ");
                userData = double.Parse(Console.ReadLine());
                sum += userData;

                Console.Write("Digite um número: ");
                userData = double.Parse(Console.ReadLine());
                sum += userData;
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"A soma foi: {sum}");
            Console.ReadKey();
        }
    }
}
