using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjetoCSharp
{
    public class Service
    {
        public static void verificaMaiorIdade()
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("\nVoce escolheu comparar duas idades para saber quem e mais velho");
            Console.WriteLine("Insira o nome da primeira pessoa");
            Console.Write("> ");
            a.nome = Console.ReadLine();
            Console.WriteLine($"Insira a idade de {a.nome}");
            Console.Write("> ");
            a.idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome da segunda pessoa");
            Console.Write("> ");
            b.nome = Console.ReadLine();
            Console.WriteLine($"Insira a idade de {b.nome}");
            Console.Write("> ");
            b.idade = byte.Parse(Console.ReadLine());

            string pessoaMaisVelha = a.idade > b.idade ? a.nome : b.nome;

            Console.WriteLine("A pessoa mais velha e " + pessoaMaisVelha);
        }

        public static double medianaSalario()
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            double media = 0.0;
            
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (valor1 + valor2) / 2.0;

            return media;
        }
    }
}
