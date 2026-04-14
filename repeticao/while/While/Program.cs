// See https://aka.ms/new-console-template for more information

/*
int x, soma = 0;
x = int.Parse(Console.ReadLine());

while (x != 0)
{
    soma = soma + x;
    x = int.Parse(Console.ReadLine());
}
Console.WriteLine(soma);



int x = 5;
int y = 0;

while (x > 2)
{
    Console.WriteLine(x);
    y = y + x;
    x = x - 1;
}



int x = 2;
int y = 0;

while (x < 60)

{
    Console.WriteLine(x);
    x = x * 2;
    y = y + 10;
}



int x = 100;
int y = 100;

while (x != y) 
{
    Console.WriteLine("");
    x = (int)Math.Sqrt(y);
}

*/

int x = 0;
int y = 0;

while (x < 5) 
{
     y = x * 3;
    Console.WriteLine(y);
    x = x + 1;
}

Console.WriteLine("Fim");