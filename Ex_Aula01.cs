using System;

/* Exercício 01 

Console.WriteLine("Seu nome é: ");
string nome = Console.ReadLine();

Console.WriteLine("Seu sobrenome é: ");
string sobrenome = Console.ReadLine();

//Utilizando Template
Console.WriteLine($"Então seu nome completo é: {nome} {sobrenome} \n");

//Utilizando Operador
string nomeCompleto = nome + " " + sobrenome;

//Utilizando Formato
Console.WriteLine("Então seu nome completo é: {0} {1}", nome, sobrenome);

*/

/* Exercício 02 

Console.WriteLine("Seu nome é: ");
string nome = Console.ReadLine();

Console.WriteLine("Seu sobrenome é: ");
string sobrenome = Console.ReadLine();

Console.WriteLine("Sua Idade:");
string idadeTexto = Console.ReadLine();
double idade = Convert.ToDouble(idadeTexto);

Console.WriteLine("Seu Peso:");
string pesoTexto = Console.ReadLine();
double peso = Convert.ToDouble(pesoTexto);

Console.WriteLine("Sua Altura:");
string alturaTexto = Console.ReadLine();
double altura = Convert.ToDouble(alturaTexto);

double IMC = peso/ ( altura * altura);

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"IMC: {IMC}");

*/

/* Exercício 03 

Console.WriteLine("Primeiro Número: ");
string numeroTexto1 = Console.ReadLine();
int numero1 = Int32.Parse(numeroTexto1);

Console.WriteLine("Segundo Número: ");
string numeroTexto2 = Console.ReadLine();
int numero2 = Int32.Parse(numeroTexto2);

if (numero1 > 0 || numero2 > 0)
{
    Console.WriteLine("Os número precisam ser positivos");
    return;
}

if (numero2 >= numero1)
{
    Console.WriteLine("O Segundo Número precisa ser Maior que o Primeiro");
    return;
}

*/