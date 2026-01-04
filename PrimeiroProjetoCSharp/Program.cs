using PrimeiroProjetoCSharp.Entities.Service;
using PrimeiroProjetoCSharp.Entities.Model;

namespace PrimeiroProjetoCSharp;

internal class Program
{
    static void Main(string[] args)
    {

        bool exit = false;
        
        Menu menu = new Menu();
        menu.inicial();

        while (!exit)
        {  
            byte escolha = menu.Opcoes();
            switch (escolha)
            {
                case 0:
                    menu.encerramento();
                    break;
                case 1:
                    Console.Clear();
                    PessoaService service = new PessoaService();
                    Pessoa pessoaA = new Pessoa { Nome = "Diego", Atributos = new DadosFisicos { Peso = 75, Altura = 1.75 } };
                    service.Clonagem(pessoaA);
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}