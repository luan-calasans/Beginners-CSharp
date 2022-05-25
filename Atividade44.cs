using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex44
    {
        static void Main(string[] args)
        {
            // Desenvolva um programa que exiba a tabuada do usuário e pelo intervalo escolhido por ele
            double multiplier = 0, userData, start, theEnd;
            Console.WriteLine("===============");
            Console.WriteLine("    TABUADA    ");
            Console.WriteLine("===============");

            Console.Write("Informe um número a ser multiplicado: ");
            userData = double.Parse(Console.ReadLine());

            Console.Write("Informe o início do intervalo: ");
            start = double.Parse(Console.ReadLine());

            Console.Write("Informe o fim do intervalo: ");
            theEnd = double.Parse(Console.ReadLine());

            for (double control = start; start <= theEnd; start++)
            {
                Console.WriteLine($" {userData} x {start} = {start * userData}");
            }
            Console.ReadKey();
        }
    }
}
