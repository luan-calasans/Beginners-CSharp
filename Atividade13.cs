using System;

namespace PDC_ULTIMO_EXERCÍCIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P, M, G;
            Console.Write("Digite o primeiro número: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int C = int.Parse(Console.ReadLine());
            if (A > B) // A > B 
            {
                if (B < C) // A > B    ->    B < C  
                {
                    if (A > C) // A > B    ->    C > B    ->    A > C    
                    {
                        G = A;
                        P = B;
                        M = C;
                    }
                    else // A > B    ->    C > B    ->    C > A
                    { 
                        G = C; 
                        M = A;
                        P = B;
                    }
                }
                else // A > B    ->    B > C
                {
                    if (A > C) // A > B    ->    B > C    ->    A > C   
                    {
                        G = A;
                        M = B;
                        P = C;
                    }
                    else // A > B    ->    B > C    ->    C > A
                    {
                        G = C;
                        M = A;
                        P = B;
                    }
                }
            }
            else // B > A   
            {
                if (A > C) // B > A    ->    A > C         
                {
                    if (B > C) // B > A    ->    A > C    ->    B > C 
                    {
                        G = B;
                        M = A;
                        P = C;
                    }
                    else // B > A    ->    C > A    ->    C > B 
                    { 
                        G = C;
                        M = B;
                        P = A;
                    }
                }
                else // B > A    ->    C > A
                {
                    if (C > B) // B > A    ->    C > A    ->    C > B 
                    {
                        G = C;
                        P = A;
                        M = B;
                    }
                    else // B > A    ->    C > A    ->    B > C 
                    { 
                        G = C;
                        P = A;
                        M = B;
                    }
                }
            }
            Console.WriteLine($"A ordem descrescente é: {G} > {M} > {P}");
            Console.ReadKey();
        }
    }
}
