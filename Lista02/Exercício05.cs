using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora Científica");
            Console.Write("Digite um número decimal (use ponto . para separar): ");

            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                // Cálculo das operações
                double raizQuadrada = Math.Sqrt(numero); // 1. Raiz Quadrada
                double potenciaQuadrado = Math.Pow(numero, 2); // 2. Potência ao quadrado
                double valorAbsoluto = Math.Abs(numero); // 3. Valor Absoluto
                double arredondarCima = Math.Ceiling(numero); // 4. Arredondar para cima
                double arredondarBaixo = Math.Floor(numero); // 5. Arredondar para baixo

                // Exibição dos resultados
                Console.WriteLine("\nResultados");
                Console.WriteLine($"Número digitado: {numero}");
                Console.WriteLine($"Raiz quadrada: {raizQuadrada:F4}"); // 4 casas decimais
                Console.WriteLine($"Potência ao quadrado: {potenciaQuadrado}"); //
                Console.WriteLine($"Valor absoluto: {valorAbsoluto}"); //
                Console.WriteLine($"Arredondamento para cima (Ceiling): {arredondarCima}"); //
                Console.WriteLine($"Arredondamento para baixo (Floor): {arredondarBaixo}"); //
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }

            Console.ReadKey();
        }
    }
}
