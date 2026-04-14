// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;


//vmq = valort do metro quadrado
Console.WriteLine("Olá, Calcule o Valor do seu Terreno!!");
Console.WriteLine("Qual a Largura do seu terreno?");
double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Qual o comprimento do Terreno?");
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Qual o valor do metro quadrado do terreno?");
double vmq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double area = largura * comprimento;
double preco = area * vmq;

Console.WriteLine($"AREA = {area.ToString ("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PRECO = {preco.ToString("F2", CultureInfo.InvariantCulture)}");
