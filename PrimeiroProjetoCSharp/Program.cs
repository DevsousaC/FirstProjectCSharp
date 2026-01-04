using PrimeiroProjetoCSharp.Entities.Service;
using PrimeiroProjetoCSharp.Entities.Model;
using PrimeiroProjetoCSharp.Entities.View;

namespace PrimeiroProjetoCSharp;

internal class Program
{
    static void Main(string[] args)
    {

        bool executar = true;

        Menu menu = new Menu();
        menu.inicial();
        
        while (executar)
        {
            byte escolha = menu.Opcoes();
            switch (escolha)
            {
                case 0: // Sair
                    menu.encerramento();
                    return;
                case 1: // Simular Clonagem de Pessoa - Shallow Copy/Deep Copy
                    escolha = menu.OpcoesClonagem();
                    PessoaService pessoaService = new PessoaService();
                    Console.Clear();
                    Pessoa pessoa = new Pessoa();
                    if (escolha == 1)
                    {
                        pessoaService.ClonarShallowCopy(pessoa);
                        break;
                    }
                    else if (escolha == 2)
                    {
                        pessoaService.ClonarDeepCopy(pessoa);
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
