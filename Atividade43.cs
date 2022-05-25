using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex43
    {
        static void Main(string[] args)
        {
            // Desenvolva um programa que exiba a tabuada de acordo com o número que o usuário pedir
            double multiplier = 0, userData;
            Console.WriteLine("===============");
            Console.WriteLine("    TABUADA    ");
            Console.WriteLine("===============");
            Console.Write("Informe um número a ser multiplicado: ");
            userData = double.Parse(Console.ReadLine());
            for (int control = 0; control < 11; control++)
            {
                Console.WriteLine($" {userData} x {control} = {multiplier * userData}");
                multiplier++;
            }
            Console.ReadKey();
        }
    }
}
