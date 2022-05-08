using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex37
    {
        static void Main(string[] args)
        {
            // Exibir a soma dos números positivos do intervalo de um a cem.
            int value, sum = 0;
            try
            {
                do
                {
                    Console.Write("Digite um número positivo (entre 1 e 100): ");
                    value = int.Parse(Console.ReadLine());
                    sum += value;
                } while (sum > 0 && sum < 100);
            }
            catch
            {
                Console.WriteLine("Digite apenas números positivos!");
            }
            Console.WriteLine($"Soma = {sum}");
            Console.ReadKey();
        }
    }
}
