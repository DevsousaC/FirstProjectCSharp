using PrimeiroProjetoCSharp.Entities.Service;

namespace PrimeiroProjetoCSharp.Entities.View
{
    internal class Menu
    {
        public String barraHorizontal = "═════════════════════════════════════════════════════════════════════════════════════════════════════";


        public void inicial()
        { 
            string titulo = @"

##     ## ######## ##       ##        #######    ##      ##  #######  ########  ##       ########  ##
##     ## ##       ##       ##       ##     ##   ##  ##  ## ##     ## ##     ## ##       ##     ## ##
##     ## ##       ##       ##       ##     ##   ##  ##  ## ##     ## ##     ## ##       ##     ## ##
######### ######   ##       ##       ##     ##   ##  ##  ## ##     ## ########  ##       ##     ## ##
##     ## ##       ##       ##       ##     ##   ##  ##  ## ##     ## ##   ##   ##       ##     ## ##
##     ## ##       ##       ##       ##     ##   ##  ##  ## ##     ## ##    ##  ##       ##     ## 
##     ## ######## ######## ########  #######     ###  ###   #######  ##     ## ######## ########  ##

            ";

            Console.Clear();
            Console.WriteLine(titulo + "\n" + barraHorizontal);
            Console.Title = "Algebra Linear - Ferramentas";
        }

        public byte Opcoes()
        {
            Console.Clear();

            List<string> opcoesDisponivel = new List<string> { "Sair", "Simular Clonagem de Pessoa - Shallow Copy/Deep Copy", "media de salario", "quem alugou mais quartos hoje" };

            Console.WriteLine("\nEntre duas pessoas eu quero verificar...");

            for(int i = 1; i < opcoesDisponivel.Count; i++)
            {
                Console.WriteLine($"[{i}] " + opcoesDisponivel[i]);
            }

            Console.WriteLine("\nVoce tambem pode escolher");
            Console.WriteLine("[0] Sair");

            Console.WriteLine("\n" + barraHorizontal);

            Console.Write("> ");
            return byte.Parse(Console.ReadLine());
        }

        public byte OpcoesClonagem()
        {
            Console.Clear();

            List<string> opcoesDisponivel = new List<string> { "Sair", "Shallow Copy", "Deep Copy" };

            Console.WriteLine("\nQue tipo de clonagem você gostaria...?");

            for (int i = 1; i < opcoesDisponivel.Count; i++)
            {
                Console.WriteLine($"[{i}] " + opcoesDisponivel[i]);
            }

            Console.WriteLine("\nVoce tambem pode escolher");
            Console.WriteLine("[0] Sair");

            Console.WriteLine("\n" + barraHorizontal);

            Console.Write("> ");
            byte escolha = byte.Parse(Console.ReadLine());

            return escolha;
        }

        public void encerramento() 
        {
            Console.Clear();
            Console.WriteLine("\"Encerrando o programa... Até logo!\"");
            Thread.Sleep(1000);
        }
    }
}
