using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex28
    {
        static void Main(string[] args)
        {
            /*
                Desenvolva um progrma que receba via teclado 4 números e utilizando duas variáveis exiba
                o maior. Ps: fazer as quatro estruturas idênticas
             */
            double userData = 0, bigger = 0;
            try
            {
                Console.Write("Digite um número: ");
                bigger = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadLine();
                return;
            }

            if (userData > bigger)
            {
                bigger = userData;
            }
            Console.Write("Digite um número: ");
            userData = double.Parse(Console.ReadLine());

            if (userData > bigger)
            {
                bigger = userData;
            }
            Console.Write("Digite um número: ");
            userData = double.Parse(Console.ReadLine());

            if (userData > bigger)
            {
                bigger = userData;
            }
            Console.Write("Digite um número: ");
            userData = double.Parse(Console.ReadLine());

            if (userData > bigger)
            {
                bigger = userData;
            }

            Console.WriteLine($"O maior é: {bigger}");
            Console.ReadKey();
        }
    }
}
