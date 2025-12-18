namespace PrimeiroProjetoCSharp;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();

        Pessoa pessoa1, pessoa2;
        pessoa1 = new Pessoa();
        pessoa2 = new Pessoa();

        Console.WriteLine("Qual o nome da primeira pessoa: ");
        pessoa1.nome = Console.ReadLine();
        Console.WriteLine($"Qual a idade de {pessoa1.nome} ");
        pessoa1.idade = byte.Parse(Console.ReadLine());

        Console.WriteLine("Qual o nome da segunda pessoa: ");
        pessoa2.nome = Console.ReadLine();
        Console.WriteLine($"Qual a idade de {pessoa2.nome} ");
        pessoa2.idade = byte.Parse(Console.ReadLine());

        string pessoaMaisVelha = pessoa1.idade > pessoa2.idade ? pessoa1.nome : pessoa2.nome;

        Console.WriteLine("A pessoa mais velha e: " + pessoaMaisVelha);

    }
}