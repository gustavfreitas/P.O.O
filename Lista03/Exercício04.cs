using System;
using System.Collections.Generic;

public class Banco
{
    public Dictionary<string, double> saldos = new Dictionary<string, double>();

    public void CriarConta(string cpf)
    {
        if (saldos.ContainsKey(cpf)) return;
        saldos.Add(cpf, 0);
    }

    public bool Sacar(double valor, string cpf)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Você só pode sacar valores positivos");
            return false;
        }

        if (!saldos.ContainsKey(cpf))
        {
            Console.WriteLine("Você precisa possuir uma conta neste banco");
            return false;
        }

        double saldoAtual = saldos[cpf];

        if (saldoAtual < valor)
        {
            Console.WriteLine("Você precisa ter saldo o suficiente, seu pobre");
            return false;
        }

        saldos[cpf] -= valor;
        return true;
    }

    public bool Depositar(double valor, string cpf)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Você só pode sacar valores positivos");
            return false;
        }

        if (!saldos.ContainsKey(cpf))
        {
            Console.WriteLine("Você precisa possuir uma conta neste banco");
            return false;
        }

        saldos[cpf] += valor;
        return true;
    }
}

public class Pessoa
{
    public double dinheiroCarteira;
    string cpf;

    public string Cpf
    {
        get { return cpf; }
    }

    public void Depositar(double valor, Banco banco)
    {
        if (dinheiroCarteira < valor) return;

        bool deuCerto = banco.Depositar(valor, cpf);

        if (deuCerto)
        {
            Console.WriteLine("Consegui depositar");
            dinheiroCarteira -= valor;
        }
    }

    public void Sacar(double valor, Banco banco)
    {
        bool deuCerto = banco.Sacar(valor, cpf);

        if (deuCerto)
        {
            Console.WriteLine("Consegui sacar");
            dinheiroCarteira += valor;
        }
    }
}