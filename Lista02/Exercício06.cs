using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        // Exemplo de entrada: P1(1, 1), P2(4, 5)
        // A distância deve ser 5.0

        Console.WriteLine("Digite x1 e y1 (separados por espaço):");
        string[] p1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);

        Console.WriteLine("Digite x2 e y2 (separados por espaço):");
        string[] p2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        // d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2))
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"A distância euclidiana é: {distancia:F4}");
    }
}
