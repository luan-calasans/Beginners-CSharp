using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex64
    {
        static int hour, multi;
        static void Main(string[] args)
        {
            /* Construa um programa que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período 
               de 30 dias (ele trabalhou todos os 30 dias) e apresente o total de horas trabalhadas por ele nesse período. */
            hourWorked();
            Console.ReadKey();
        }
        static void hourWorked()
        {
            Console.Write("Digite a quantidades de horas diárias trabalhadas: ");
            hour = int.Parse(Console.ReadLine());

            multi = 30 * hour;

            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write($"O total de horas trabalhadas no mês foi de {multi}");
        }
    }
}
