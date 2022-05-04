using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex35
    {
        static void Main(string[] args)
        {
            // Entrar com dois valores via teclado, onde o segundo deverá ser maior que o primeiro.
            // Caso contrário solicitar novamente apenas o segundo valor.
            double firstValue = 0, secondValue = 0;
            try
            {
                Console.Write("Digite o 1º valor: ");
                firstValue = double.Parse(Console.ReadLine());
                Console.Write("Digite o 2º valor: ");
                secondValue = double.Parse(Console.ReadLine());
                
                while(firstValue >= secondValue)
                {
                    Console.WriteLine("O 2º valor deve ser maior que o primeiro");
                    Console.Write("Digite novamente o 2º valor: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.Write("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("O 2º valor é o maior");
            Console.ReadKey();
        }
    }
}
