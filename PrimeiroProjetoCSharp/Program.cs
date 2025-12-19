using System.Net.Http.Headers;

namespace PrimeiroProjetoCSharp;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Escolha o que fazer:");

        byte escolha = byte.Parse(Console.ReadLine());
        Service service;

        switch (escolha)
        {
            case 1:
                service = new Service();
                string pessoaMaisVelha = service.verificaMaiorIdade();
                Console.WriteLine("A pessoa mais velha e" + pessoaMaisVelha); 
                break;
            case 2:
                service = new Service();
                double mediaSalario = service.medianaSalario();
                Console.WriteLine("A media de salario e: " + mediaSalario.ToString("F2"));
                break;
        }
    }
}