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
                    Service.verificaMaiorIdade();
                    break;
                case 2:
                    Console.Clear();
                    double mediaSalario = Service.medianaSalario();
                    Console.WriteLine("A media de salario e: " + mediaSalario.ToString("F2"));
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}