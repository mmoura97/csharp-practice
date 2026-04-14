using System;
using System.Globalization;


namespace EstruturasCondicionais
{
    public static class Exercicios
    {
        public static void Exercicio1()
        {
            double n1 = 0;
            double n2 = 0;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double mediafinal = (n1 + n2) / 2;
            if (mediafinal <= 60.0)
            {
                Console.WriteLine($"Sua média é {mediafinal.ToString("F2", CultureInfo.InvariantCulture)}, e esta reprovado!");
            }
            else
            {
                Console.WriteLine($"Sua média é {mediafinal.ToString("F2", CultureInfo.InvariantCulture)}, e esta Aprovado");
            }
        }

        public static void ExercicioUri1036()
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite três números inteiros:");

            string[] numeros = Console.ReadLine().Split(' ');

            int numeroint1 = int.Parse(numeros[0]);
            int numeroint2 = int.Parse(numeros[1]);
            int numeroint3 = int.Parse(numeros[2]);

            if (numeroint1 < numeroint2 && numeroint1 < numeroint3)
            {
                Console.WriteLine($"MENOR = {numeroint1}");
            }
            else if (numeroint2 < numeroint1 && numeroint2 < numeroint3)
            {
                Console.WriteLine($"MENOR = {numeroint2}");
            }
            else
            {
                Console.WriteLine($"MENOR = {numeroint3}");
            }
        }

        // Exercício 4: Cálculo de conta telefônica atribuicão cumulativa 
        public static void Exercicio4() {

            double contas;
            int minutos = int.Parse(Console.ReadLine());

            contas = 50.0;
            if (minutos > 100) 
            {
                contas = contas + (minutos - 100) * 2.0;
            }
            Console.WriteLine($"Valor a Pagar R$ {contas.ToString("F2", CultureInfo.InvariantCulture)}");



        }

    }
}

