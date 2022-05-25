using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ex42
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que exiba a tabuada do 3 */
            double multiplier = 0;
            Console.WriteLine("===============");
            Console.WriteLine(" TABUADA DO 3 ");
            Console.WriteLine("===============");
            for (int control = 0; control < 11; control++)
            {
                Console.WriteLine($" 3 x {control} = {multiplier * 3}");
                multiplier++;
            }
            Console.ReadKey();
        }
    }
}