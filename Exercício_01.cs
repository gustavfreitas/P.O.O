using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

// Exercício 01
/*
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem Vindo, {nome}!");
*/

// Exercício 02
/*
int numero1 = 5;
int numero2 = 10;

Console.WriteLine($"A soma de {numero1} e {numero2} é: {numero1 + numero2}");
*/

// Exercício 03

/*
double nota1= 7.5;
double nota2 = 8.0;
double nota3 = 6.0;

double media = (nota1 + nota2 + nota3) / 3;

media = Math.Round(media, 2);  

Console.WriteLine($"A sua média de notas é: {media}");
*/

// Exercício 04

/*
int temperaturaCelsius = 25;

int fahrenheit = (temperaturaCelsius * 9 / 5) + 32;

Console.WriteLine($"A temperatura de {temperaturaCelsius}°C é equivalente a {fahrenheit}°F");
*/

// Exercício 05

/*

int numero1 = 10;
int numero2 = 2;

int soma = numero1 + numero2;

Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}");

int subtracao = numero1 - numero2;

Console.WriteLine($"A subtração de {numero1} e {numero2} é: {subtracao}");

int multiplicacao = numero1 * numero2;

Console.WriteLine($"A multiplicação de {numero1} e {numero2} é: {multiplicacao}");

int divisao = numero1 / numero2;

Console.WriteLine($"A divisão de {numero1} e {numero2} é: {divisao}");

*/

// Exercício 06

/*

int basi = 5;
int altura = 10;

int area = (basi * altura);

Console.WriteLine($"A área do retângulo é: {area}");

*/

// Exercício 07

/*

int a = 10;

bool resultado = a % 2 == 0;

Console.WriteLine($"O número {a} é par? {resultado}");

*/

// Exercício 08

/*

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");

*/

// Exercício 09
/*

Console.WriteLine("Escreva uma Frase: ");
string frase = Console.ReadLine();

int quantidadeCaracteres = frase.Length;
quantidadeCaracteres = Console.ReadLine().Length;

Console.WriteLine($"A quantidade de caracteres na frase é: {quantidadeCaracteres}");
*/

// Exercício 10

/*

Console.WriteLine("Escreva uma Frase: ");
string frase = Console.ReadLine();

Console.WriteLine($"A frase em maiúscula é: {frase.ToUpper()}\n");
Console.WriteLine($"Frase em minúscula é: {frase.ToLower()}\n");

string sohInicio =  frase.TrimStart();
string sohFim = frase.TrimEnd();

Console.WriteLine($"Frase sem espaços no início: '{sohInicio}'\n");
Console.WriteLine($"Frase sem espaços no fim: '{sohFim}'\n");

*/

// Exercício 11

/*

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu salário: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Seu Percentual de Desconto eh: ");
double percentualDesconto = Convert.ToDouble(Console.ReadLine());

double salarioliquido = salario - (salario * percentualDesconto / 100);

Console.WriteLine($"O salário líquido de {nome} é: {salarioliquido}");

*/

// Exercício 12

/*

int numero = 8560;

int horas = numero / 3600;
int minutos = (numero % 3600) / 60;
int segundos = numero % 60;

string formatado = $"{horas:D2}:{minutos:D2}:{segundos:D2}";
Console.WriteLine($"O número {numero} em formato de horas, minutos e segundos é: {formatado}");

*/

// Exercício 13

/*

double peso = 70.0;
double altura = 1.75;

double imc = peso / (altura * altura);
Console.WriteLine($"O IMC é: {imc:F2}");

*/

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

*/

// Exercício 15

/*

Console.WriteLine("Nome do Produto: ");
string nomeProduto = Console.ReadLine();

Console.WriteLine("Preço do Produto: ");
double precoProduto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade do Produto: ");
int quantidadeProduto = Convert.ToInt32(Console.ReadLine());


double subtotal = precoProduto * quantidadeProduto;
Console.WriteLine($"O subtotal do produto {nomeProduto} é: {subtotal}");

double desconto = 10;
Console.WriteLine($"O desconto aplicado é de: {desconto}%");

string totalfinal = (desconto > 0) ? $"O total com desconto é: {subtotal - (subtotal * desconto / 100)}" : $"O total sem desconto é: {subtotal}";
Console.WriteLine(totalfinal);

*/

// Exercício 16

/*

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a sua Cidade: ");
string cidade = Console.ReadLine();

Console.WriteLine("Informe a sua profissão: ");
string profissao = Console.ReadLine();

string ficha = $"Nome: {nome} | Idade: {idade} | Cidade: {cidade} | Profissão: {profissao}";
Console.WriteLine($"Ficha Completa: {ficha}");

*/

// Exercício 17

/*

double b = 12.63;

int meuInt = (int)b;
Console.WriteLine(meuInt);

long meuLong = (long)b;

double numeroResto = (meuInt - b);
Console.WriteLine(numeroResto);

*/

// Exercício 18

/*

double capital = 1000.00;

double juros = 5;

double meses = 12;

double montante = capital * Math.Pow(1 + juros/100, meses);
Console.WriteLine($"O Calculo do resultado do montante acumulado sera: R${montante}");

*/

// Exercício 19

/*

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string sobrenome = Console.ReadLine();

Console.WriteLine("Informe o nome da Empresa:");
string empresa = Console.ReadLine();

Console.WriteLine($"Endereco de email: {nome}.{sobrenome}@{empresa}.com.br ");

*/

// Exercício 20

/*

Console.WriteLine("Digite a senha:");
string senha = Console.ReadLine();

int totalCarac = senha.Length;
Console.WriteLine($"Numero de quantos caracteres tem a senha: {totalCarac}");

char num = '1';
bool temNum = char.IsDigit(num);

char maiusculo = 'A';
bool temMaius = char.IsUpper(maiusculo);

Console.WriteLine($"E a senha possui um numero? {temNum}, a senha tem letra Maiuscula? {temMaius}.");

*/
