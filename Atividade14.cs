using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades
{
    class ex14
    {
        static void Main(string[] args)
        {
            // DESENVOLVA UM PROGRAMA QUE RECEBA VIA TECLADO A ALTURA (m) DO USUÁRIO E CLASSIFIQUE-O DE ACORDO COM SUA ALTURA
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
