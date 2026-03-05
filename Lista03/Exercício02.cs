using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Produto
{

    public string nome = "Detergente";
    public int preco = 6;
    public int quantidade = 10;

    public void Estoque(string nomeAtributo, int precoAtributo, int quantidadeAtributo)
    {
        nome = nomeAtributo;
        preco = precoAtributo;
        quantidade = quantidadeAtributo;
    }
    public void CalcularValorTotal() 
    {
        int total = (preco * quantidade);

    Console.WriteLine($"O Valor total em estoque do produto {nome} eh: {total}");
    }


}
