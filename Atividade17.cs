using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_lista03_ex01
{
    internal class C37461_lista03_ex01
    {
        static void Main(string[] args)
        {
            // Entrar via teclado, com dois valores distintos.
            // Exibir o maior deles.
            double primeiroValor = 0, segundoValor = 0;

            try
            {
                Console.Write("Digite o primeiro valor: ");
                primeiroValor = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                segundoValor = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }

            if (primeiroValor > segundoValor)
            {
                Console.WriteLine($"O maior é o 1º valor: {primeiroValor}");
            }
            else
            {
                Console.WriteLine($"O maior é o 2º valor: {segundoValor}");
            }
            Console.ReadKey();
        }
    }
}
