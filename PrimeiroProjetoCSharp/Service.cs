using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjetoCSharp
{
    public class Service
    {
        public String verificaMaiorIdade()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Voce escolheu comparar duas idades para saber quenm e mais velho");
            Console.WriteLine("Qual o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {pessoa1.nome} ");
            pessoa1.idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine($"Qual a idade de {pessoa2.nome} ");
            pessoa2.idade = byte.Parse(Console.ReadLine());

            string pessoaMaisVelha = pessoa1.idade > pessoa2.idade ? pessoa1.nome : pessoa2.nome;

            return pessoaMaisVelha;
        }

        public double medianaSalario()
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
