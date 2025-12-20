using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjetoCSharp
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

            Console.WriteLine(titulo + "\n" + barraHorizontal);
            Console.Title = "Algebra Linear - Ferramentas";
        }

        public byte Opcoes()
        {
            List<string> opcoesDisponivel = new List<string> { "Sair", "quem tem a maior idade", "media de salario" };

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

        public void encerramento() 
        {
            Console.Clear();
            Console.WriteLine("\"Encerrando o programa... Até logo!\"");
            Thread.Sleep(1000);
            return;
        }
    }
}
