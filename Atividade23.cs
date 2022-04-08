using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_lista03_ex08
{
    class C37461_lista03_ex08
    {
        static void Main(string[] args)
        {
            // Verificar se três valores quaisquer (A, B, C) que serão digitados formam ou não um triângulo 
            // retângulo. Lembre-se que o quadrado da hipotenusa é igual a soma dos quadrados dos catetos
            double A = 0, B = 0, C = 0, teste = 0, soma = 0;
            try
            {
                Console.Write("Digite o valor da hipotenusa (a): ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do cateto (b): ");
                B = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do cateto (c): ");
                C = double.Parse(Console.ReadLine());
                teste = Math.Pow(A,2);
                soma = Math.Pow(B,2) + Math.Pow(C,2);
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }
            if (teste == soma)
            {
                Console.WriteLine("Os lados formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os lados digitados não formam um triângulo retângulo.");
            }
            Console.ReadKey();
        }
    }
}
