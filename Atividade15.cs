using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDADE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()); 

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("Você é adolescente");
            }
            else if (idade >= 18 && idade <= 60)
            {
                Console.WriteLine("Você é adulto");
            }
            else
            {
                Console.WriteLine("Você é idoso(a)");
            }

            Console.ReadKey();
        }
    }
}
