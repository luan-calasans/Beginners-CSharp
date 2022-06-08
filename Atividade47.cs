using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaFOR_ex01
{
    internal class C37461_ListaFOR_ex01
    {
        static void Main(string[] args)
        {
            /*
                Entrar via teclado com dez valores positivos. Consistir a digitação e enviar mensagem de erro, se necessário. Após a digitação, exibir: 
                a. O maior valor;
                b. A soma dos valores;
                c. A média aritmética dos valores;
             */
            double value, bigger = 0, sum = 0, average;
            try
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.Write("Digite um valor: ");
                    value = double.Parse(Console.ReadLine());
                    while (value < 0)
                    {
                        Console.Write("Erro!\nDigite um valor: ");
                        value = double.Parse(Console.ReadLine());
                    }
                    if (bigger < value)
                    {
                        bigger = value;
                    }
                    sum += value;
                }
                average = sum / 10;
                Console.Write($"Maior valor: {bigger}\nSoma dos valores: {sum}\nMédia: {average}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Digite apenas número!");
                Console.ReadKey();
                return;
            }
        }
    }
}
