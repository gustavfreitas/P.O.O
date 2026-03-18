using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número inicial para a contagem regressiva: ");
        if (int.TryParse(Console.ReadLine(), out int numeroInicial))
        {
            Console.WriteLine($"Iniciando contagem de {numeroInicial} até 0:");
            for (int i = numeroInicial; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); // Pausa de 500 milissegundos (meio segundo) para efeito visual
            }
            Console.WriteLine("Fim da contagem regressiva!");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
}
