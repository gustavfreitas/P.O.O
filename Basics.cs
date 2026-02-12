using System;

// Console é da Categoria de algoritmo chamado: CLASSE
// O Ponto (.) é a forma de acessar as informações da Classe.
// WriteLine é da Categoria de algoritmo chamado: MÉTODO.

Console.WriteLine("Hello, World! \n");

/* Variáveis */

string nome = "Gustavo";
int idade = 21;

/* Exemplos */

Console.Write("Seu nome: ");
Console.Write(nome);
Console.Write("\n");
Console.Write("Idade atual: ");
Console.Write(idade);
Console.Write("\n");

/* ------ // ------- */

Console.WriteLine("Seu nome: " + nome);
Console.WriteLine("Idade atual: " + idade);

/* Incrementos */

// Concatenação
Console.WriteLine("Meu nome é {0} e minha idade é de {1} anos.", nome, idade);

// Outra forma
Console.WriteLine($"Meu nome é {nome} e minha idade é de {idade} anos.");

// ReadLine é o Método utilizado para Ler String, o Readline ao ler a string só irá devolver em String.
// Ao menos que utilize o Int32.Parse, assim podendo devolver em Inteiro e não como String.
Console.WriteLine("Digite um número");
string valor = Console.ReadLine();
int numero = Int32.Parse(valor);
idade++;







