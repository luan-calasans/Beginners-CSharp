using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex62
    {
        static double weight, sum;
        static void Main(string[] args)
        {
            /* Construa um programa que apresente o peso total que será carregado por um caminhão. 
               Sabe-se que esse caminhão carrega 25 caixas, com pesos diferentes. Será entrada do 
               programa o peso (P) de cada uma das caixas. */
            repeat();
            Console.ReadKey();
        }

        private static void repeat()
        {
            for (int i = 1; i < 26; i++)
            {
                Console.Write($"Digite o peso da {i}º caixa: ");
                weight = double.Parse(Console.ReadLine());
                sum += weight;
            }
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("O peso total foi de: " + sum);
        }
    }
}
