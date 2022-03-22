using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            if (altura < 1.76)
            {
                if (altura < 1.60)
                {
                    Console.Write("Você tem estatura baixa.");
                }
                else
                {
                    Console.Write("Você tem estatura mediana.");
                }
            }
            else
            {
                if (altura < 2)
                {
                    Console.Write("Você tem estatura alta.");
                }
                else
                {
                    Console.Write("Você tem estatura muito alta.");
                }
            }
            Console.ReadKey();
        }
    }
}
