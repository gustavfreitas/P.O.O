using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int numero;
        int soma = 0;

        do
        {
            Console.Write("Digite um número (ou 0 para parar): ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine($"A soma total é: {soma}");
    }
}
