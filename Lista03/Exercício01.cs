using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string nome = "Gustavo";
    public int idade = 21;
    public double altura = 1.72;


    public void AtribuirDados(string nomeAtributo, int idadeAtributo, double alturaAtributo)
    {
        nome = nomeAtributo;
        idade = idadeAtributo;
        altura = alturaAtributo;
    }

    public void Apresentar() 
    {
        Console.WriteLine($"Ficha da Pessoa: {nome}, {idade} anos, {altura} metros.");
    }

}

