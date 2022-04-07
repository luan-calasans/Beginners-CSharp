using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_lista03_ex03
{
    internal class C37461_lista03_ex03
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com três valores distintos. Exibir o maior deles.
            double primeiroValor = 0, segundoValor = 0, terceiroValor = 0;

            try 
            { 
                Console.Write("Digite o primeiro valor: ");
                primeiroValor = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                segundoValor = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                terceiroValor = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }

            if (primeiroValor > segundoValor && primeiroValor > terceiroValor) // true
            {
                Console.WriteLine($"O 1º valor: {primeiroValor} é o maior.");
            }
            else if (segundoValor > primeiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine($"O 2º valor: {segundoValor} é o maior.");
            }
            else 
            {
                Console.WriteLine($"O 3º valor: {terceiroValor} é o maior.");
            }
            Console.ReadKey();
        }
    }
}
