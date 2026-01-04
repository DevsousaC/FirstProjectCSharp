using PrimeiroProjetoCSharp.Entities.Model;

namespace PrimeiroProjetoCSharp.Entities.Service
{
    public class PessoaService
    {
        // 1. Simular a clonagem de uma pessoa (shallow copy e deep copy)
        public void Clonagem(Pessoa pessoaA)
        {
            Console.WriteLine("Pessoa A:");
            Console.WriteLine($"Nome: {pessoaA.Nome}, Peso: {pessoaA.Atributos.Peso} kg, Altura: {pessoaA.Atributos.Altura} m");

            // 1stp - "Clonar" a pessoa A para a pessoa B (shallow copy)
            Console.WriteLine("\n> Iniciando clonagem... \n");

            Pessoa pessoaB = pessoaA;
            
            Console.WriteLine("Pessoa B:");
            Console.WriteLine($"Nome: {pessoaB.Nome}, Peso: {pessoaB.Atributos.Peso} kg, Altura: {pessoaB.Atributos.Altura} m");

            // 2stp - Modificar algum atributo da pessoa B
            Console.WriteLine("\n> Diferenciando o clone do original... \n");

            pessoaB.Nome = "Carlos";
            pessoaB.Atributos.Peso = 85;

            Console.WriteLine("Pessoa B:");
            Console.WriteLine($"Nome: {pessoaB.Nome}, Peso: {pessoaB.Atributos.Peso} kg, Altura: {pessoaB.Atributos.Altura} m");

            // 3stp - Exibir os dados das duas pessoas
            Console.WriteLine("\n> Erro: Alteracão realizada em ambas as pessoas... \n");

            Console.WriteLine("Pessoa A:");
            Console.WriteLine($"Nome: {pessoaA.Nome}, Peso: {pessoaA.Atributos.Peso} kg, Altura: {pessoaA.Atributos.Altura} m");
            Console.WriteLine("Pessoa B:");
            Console.WriteLine($"Nome: {pessoaB.Nome}, Peso: {pessoaB.Atributos.Peso} kg, Altura: {pessoaB.Atributos.Altura} m");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
    }
}
