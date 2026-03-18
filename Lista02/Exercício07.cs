using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um número para ver a tabuada: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine($"\nTabuada do {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i,2} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
            }
            Console.ReadKey();
        }
    }
}
