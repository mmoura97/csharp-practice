// See https://aka.ms/new-console-template for more information



using System;
using System.Globalization;

// Tipos de Variáveis
int number = 10;
Console.WriteLine(number);
float decimalNumber = 10.5f;
Console.WriteLine(decimalNumber);
double largeDecimalNumber = 10.5;
Console.WriteLine(largeDecimalNumber);
char sexo = 'M';
Console.WriteLine(sexo);
string nome = "Matheus";
Console.WriteLine(nome);
bool isTrue = true;
Console.WriteLine(isTrue);


// Operadores Aritméticos

int x = 10;
int y = 5;
double z = 10.35784;
int soma =  10 + 5;
Console.WriteLine(soma);
int subtracao = (x - y);
int multiplicacao = (x * y);
int divisao = (x / y);
int resto = (x % y);

Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);
Console.WriteLine(resto);
Console.WriteLine(z);

//Formatacao de números e invariantCulture
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F5"));
Console.WriteLine(x.ToString("F2" , CultureInfo.InvariantCulture));
Console.WriteLine($"Bom dia o valor do pão é {x} e voce disse que  é {sexo} então é mais caro, tipo para gringo");

// Variáveis e Atribuição
int a, c;
a = 5;
c = a + 10;
Console.WriteLine(a);
Console.WriteLine(c);


// Constantes e Calculando a área de um trapézio
double b, B, h, area;
b = 6.0;
B = 8.0;
h = 5.0;

area = (b + B) / 2.0 * h;
Console.WriteLine(area);

// Entrada de Dados
string frase = Console.ReadLine();
string d = Console.ReadLine();
string f = Console.ReadLine();
string g = Console.ReadLine();
Console.WriteLine($"Você digitou: {frase}");
Console.WriteLine($"Você digitou: {d}");
Console.WriteLine($"Você digitou: {f}");
Console.WriteLine($"Você digitou: {g}");

// Entrada de Dados com Split
//string[] split3 = Console.ReadLine().Split(' ');
string s = Console.ReadLine();
string[] valores = s.Split(' ');
string p1 = valores[0];
string p2 = valores[1];
string p3 =valores[2];

Console.WriteLine($"Você digitou: {p1}");
Console.WriteLine($"Você digitou: {p2}");
Console.WriteLine($"Você digitou: {p3}");


// Entrada de Dados e Conversão

char ch = char.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


string[] vet = Console.ReadLine().Split(' ');
string nome1 = vet[0];
char sexo1 = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou: ");
Console.WriteLine(ch);
Console.WriteLine(n1);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome1);
Console.WriteLine(sexo1);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



//Ex Entrada de Dados e Conversão
Console.WriteLine("Entre com seu nome completo: ");
string nomeCompleto = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int numerodeQuartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o seu ultimo nome, idade e altura (mesma linha):");
string[] dados = Console.ReadLine().Split(' ');
string ultimoNome = dados[0];
int idadea = int.Parse(dados[1]);
double alturaa= double.Parse(dados[2], CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Dados digitados:");
Console.WriteLine(nomeCompleto);
Console.WriteLine(numerodeQuartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine(ultimoNome);
Console.WriteLine(idadea);
Console.WriteLine(alturaa.ToString("F2", CultureInfo.InvariantCulture));



// Funções Matemáticas

double x1 = 3.0;
double y1 = 4.0;
double z1 = -5.0;
double A, B1, C;

A = Math.Sqrt(x1);
B = Math.Sqrt(y1);
C = Math.Sqrt(25.0);
Console.WriteLine($"Raiz quadrada de {x1} = {A}");
Console.WriteLine($"Raiz quadrada de {y1} = {B1}");
Console.WriteLine($"Raiz quadrada de 25 = {C}");

A = Math.Pow(x, y);
B = Math.Pow(x, 2.0);
C = Math.Pow(5.0, 2.0);
Console.WriteLine($"{x} elevado a {y} = {A}");
Console.WriteLine($"{x} elevado ao quadrado = {B}");
Console.WriteLine($"5 elavado ao quadrado = {C}");

A = Math.Abs(y);
B = Math.Abs(z);
Console.WriteLine($"Valor absoluto de {y} = {A}");
Console.WriteLine($"Valor absoluto de {z1} = {B}");


