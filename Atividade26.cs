using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class ex26
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo que verifique se um número informado é par ou impar
            int isOddsEvens = 0;
            try
            {
                Console.Write("Digite um número: ");
                isOddsEvens = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas número!");
                Console.ReadKey();
                return; 
            }
            if (isOddsEvens % 2 == 0)
            {
                Console.WriteLine("O número informado é par");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar");
            }
            Console.ReadKey();
        }
    }
}
