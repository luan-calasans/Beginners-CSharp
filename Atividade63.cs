using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex63
    {
        static int product;
        static double price, multi, total = 0;
        static void Main(string[] args)
        {
            /* Construa um programa que leia a quantidade (Q) e o preço (PR) de 45 produtos diferentes, 
               comprados por uma empresa, e apresente o total gasto por ela. */
            purchase();
            Console.ReadKey();
        }
        static void purchase()
        {
            for (int i = 1; i < 46; i++)
            {
                Console.Write($"Digite a quantidade do {i}º produto: ");
                product = int.Parse(Console.ReadLine());
                Console.Write("Digite o preço desse produto: R$");
                price = double.Parse(Console.ReadLine());

                multi = product * price;

                total += multi;
            }
            Console.Write("O total gasto pela empresa foi de: R$" + total);
        }
    }
}
