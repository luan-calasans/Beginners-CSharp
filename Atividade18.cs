using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_lista03_ex02
{
    internal class C37461_lista03_ex02
    {
        static void Main(string[] args)
        {
            // Entrar com dois valores quaisquer. Exibir o maior deles, se existir,
            // caso contrário, enviar mensagem avisando que os números são idênticos.
            double primeiroValor = 0, segundovalor = 0;
            try
            {
                Console.Write("Digite o primeiro valor: ");
                primeiroValor = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                segundovalor = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }

            if (primeiroValor == segundovalor)
            {
                Console.WriteLine($"O 1º e o 2º valor são iguais");
            }
            else if (primeiroValor > segundovalor)
            {
                Console.WriteLine($"O 1º valor: {primeiroValor} é o maior");
            }
            else
            {
                Console.WriteLine($"O 2º valor: {segundovalor} é o maior");
            }
            Console.ReadKey();
        }
    }
}
