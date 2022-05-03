using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex34
    {
        static void Main(string[] args)
        {
            // Desenvolva um programa que receba números aleatoriamente enquanto a soma dos números digitados é menor que 100 e exibir a quantidade de números digitados
            double userData, sum = 0, count = 0;
            try
            {
                do
                {
                    Console.Write("Digite um número: ");
                    userData = double.Parse(Console.ReadLine());
                    sum += userData;
                    count++;
                } while (sum < 100);
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Foi digitado {count} números");
            Console.ReadKey();
        }
    }
}
