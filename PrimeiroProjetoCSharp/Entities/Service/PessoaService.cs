using PrimeiroProjetoCSharp.Entities.Model;

namespace PrimeiroProjetoCSharp.Entities.Service
{
    public class PessoaService
    {

        // 1. (shallow copy) Clonar uma pessoa (referência) para outra pessoa (referência)
        public void ClonarShallowCopy(Pessoa pessoaA)
        {
            Console.WriteLine("Pessoa A:");
            Console.WriteLine(pessoaA.ToString());

            // 1stp - "Clonar" a pessoa A para a pessoa B
            Console.WriteLine("\n> Iniciando clonagem... (Shallow Copy)\n");

            Pessoa pessoaB = pessoaA;
            
            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());

            // 2stp - Modificar algum atributo da pessoa B
            Console.WriteLine("\n> Diferenciando o clone do original... \n");

            pessoaB.Nome = "Carlos";
            pessoaB.Atributos.Peso = 85;

            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());

            // 3stp - Exibir os dados das duas pessoas
            Console.WriteLine("\n> Erro: Alteracão realizada em ambas as pessoas... \n");
            Console.WriteLine("> Erro: pessoaA e pessoaB são ponteiros para a mesma parte da memoria alocada... \n");

            Console.WriteLine("Pessoa A:");
            Console.WriteLine(pessoaA.ToString());
            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }

        // 2. (Deep Copy) de forma manual, criar uma cópia completa de uma pessoa
        public void ClonarDeepCopy(Pessoa pessoaA)
        {
            Console.WriteLine("Pessoa A:");
            Console.WriteLine(pessoaA.ToString());

            // 1stp - Instanciar a pessoaB recebendo os atributos da pessoa A
            Console.WriteLine("\n> Iniciando clonagem... (Shallow Copy)\n");

            Pessoa pessoaB = new Pessoa(true)
            {
                Nome = pessoaA.Nome,
                Atributos = pessoaA.Atributos
            };

            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());

            // 2stp - Modificar algum atributo da pessoa B
            Console.WriteLine("\n> Diferenciando o clone do original... \n");

            pessoaB.Nome = "Ogied";
            pessoaB.Atributos.Altura = 1.15;
            pessoaB.Atributos.Peso = 21;

            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());

            // 3stp - Exibir os dados das duas pessoas
            Console.WriteLine("\n> Sucesso: Copias diferenciadas... \n");
            Console.WriteLine("\n> Sucesso: pessoaA e pessoaB são diferentes ... \n");

            Console.WriteLine("Pessoa A:");
            Console.WriteLine(pessoaA.ToString());
            Console.WriteLine("---");
            Console.WriteLine("Pessoa B:");
            Console.WriteLine(pessoaB.ToString());
            Console.WriteLine("-----------------");
        }
    }
}
