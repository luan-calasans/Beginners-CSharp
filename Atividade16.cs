using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DESENVOLVA UM PROGRAMA QUE RECEBA 3 VALORES VIA TECLADO E VERIFIQUE
            SE OS MESMOS FORMAM UM TRIÂNGULO
            ----
            TIPOS DE TRIÂNGULO
            1. EQUILÁTERO = TODOS OS LADOS IGUAIS
            2. ISÓSCELES = DOIS LADOS IGUAIS UM DIFERENTE
            3. ESCALENO = TODOS OS LADOS DIFERENTES
            */
            Console.WriteLine("=======================");
            Console.WriteLine("   TESTE DE TRIÂNGULO  ");
            Console.WriteLine("=======================");
            Console.Write("Digite o primeiro valor: ");
            double primeiroLado = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double segundoLado = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            double terceiroLado = double.Parse(Console.ReadLine());
            if (primeiroLado == segundoLado && segundoLado == terceiroLado)
            {
                Console.Write("O triângulo é equilátero.");
            }
            else if (primeiroLado == segundoLado && segundoLado != terceiroLado || primeiroLado != segundoLado && segundoLado == terceiroLado || terceiroLado == primeiroLado && segundoLado != primeiroLado)
            {
                Console.Write("O triângulo é isósceles.");
            }
            else 
            {
                Console.Write("O triângulo é escaleno.");
            }
            Console.ReadKey();
        }
    }
}
