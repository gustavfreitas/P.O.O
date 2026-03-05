using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Retangulo
{
    public int largura = 100;
    public int altura = 50;
    public void CalcularArea(int larguraAtributo, int alturaAtributo)
    {
        largura = larguraAtributo;
        altura = alturaAtributo;
        int area = (largura * altura);

        Console.WriteLine($"A Area de um Retangulo sera de: {area} cm.");
    }
    public void CalcularPerimetro() 
    {
        int perimetro = 2*(largura + altura);

        Console.WriteLine($"O Perimetro de um retangulo sera de: {perimetro} cm.");
    }

}
