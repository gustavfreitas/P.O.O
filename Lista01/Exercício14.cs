using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercício 14

/*

string nomeCompleto = ("Gustavo Souza Freitas");
string[] nomes = nomeCompleto.Split(' ');
string iniciais = "";

foreach (string nome in nomes)
{ 
    if (nome.Length > 0)
    {
        iniciais += char.ToUpper(nome[0]) + ".";
    }
}

Console.WriteLine($"As iniciais de {nomeCompleto} são: {iniciais}");
