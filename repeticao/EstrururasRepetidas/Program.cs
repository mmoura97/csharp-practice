// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Runtime.Serialization;

int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int soma = 0;

while (numero != 0) 
{
    soma = soma + numero;
    numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}
Console.WriteLine(soma);