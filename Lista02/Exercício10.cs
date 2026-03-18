using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de termos (N) da sequência de Fibonacci: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int a = 0, b = 1;
                Console.WriteLine($"Os primeiros {n} termos da sequência:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");
                    int proximo = a + b;
                    a = b;
                    b = proximo;
                }
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro maior que zero.");
            }
        }
    }
}
