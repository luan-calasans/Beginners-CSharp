using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades
{
    class ex22
    {
        static void Main(string[] args)
        {
            // Entrar com o peso e a altura de uma determinada pessoa. Após a digitação, 
            // exibir se esta pessoa está ou não com seu peso ideal. 
            // Veja tabela de relação peso / altura². Relação peso/ altura²
            // Mensagem: 
            // R < 20 Abaixo do peso / R >= 20 e < 25 Peso Ideal / R >= 25 Acima do peso
            double peso = 0, altura = 0, relacaoPesoAltura = 0;
            try 
            { 
                Console.Write("Digite o peso da pessoa (Kg): ");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura da pessoa (metros): ");
                altura = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }
            relacaoPesoAltura = peso / Math.Pow(altura, 2);
            if (relacaoPesoAltura < 20)
            {
                Console.WriteLine("A pessoa está abaixo do peso.");
            }
            else if (relacaoPesoAltura >= 20 && relacaoPesoAltura < 25)
            {
                Console.WriteLine("A pessoa está no peso ideal.");
            }
            else
            {
                Console.WriteLine("A pessoa está acima do peso.");
            }
            Console.ReadKey();
        }
    }
}
