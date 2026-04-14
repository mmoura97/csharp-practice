// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aula de Switch Case");

int dia = int.Parse(Console.ReadLine());
string diaSemana;

switch (x)
{
    case 1:
        diaSemana = "Domingo";
        break;
    case 2:
        diaSemana = "Segunda-Feira";
        break;
    case 3:
        diaSemana = "Terça-Feira";
        break;
    case 4:
        diaSemana = "Quarta-feira";
        break;
    case 5:
        diaSemana = "Quinta-Feira";
        break;
    case 6:
        diaSemana = "Sexta-Feira";
}       break;
    case 7:
        diaSemana = "Sábado";
        break;
    default:
        diaSemana = "Dia inválido";
        break;
}

Console.WriteLine(diaSemana);


