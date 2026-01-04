namespace PrimeiroProjetoCSharp.Entities.Model
{
    public struct DadosFisicos
    {
        public double Altura;
        public double Peso;
        public string CorOlhos;
        public string CorCabelo;
        public string CorPele;
    }
    public class Pessoa
    {
        public string? Nome;
        public byte? Idade;
        public DateTime? DataNascimento;
        public DadosFisicos Atributos;

        public Pessoa(bool carregarVazio) { }
        public Pessoa()
        {
            Console.WriteLine("Digite o nome, altura (m) e peso (kg) da pessoa:");
            Nome = Console.ReadLine();
            Atributos = new DadosFisicos
            {
                Altura = double.Parse(Console.ReadLine()),
                Peso = double.Parse(Console.ReadLine())
            };
        }
        public Pessoa(string nome, byte? idade, DateTime? dataNascimento, DadosFisicos atributos)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            Atributos = atributos;
        }

        public string ToString()
        {
            return $"Nome: {Nome}, " +
                $"\nAltura: {Atributos.Altura}m, " +
                $"\nPeso: {Atributos.Peso}kg, ";
        }

    }
}
