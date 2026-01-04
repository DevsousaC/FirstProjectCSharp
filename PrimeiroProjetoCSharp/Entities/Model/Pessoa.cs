namespace PrimeiroProjetoCSharp.Entities.Model
{
    public class Pessoa
    {
        public string? Nome;
        public byte? Idade;
        public DateTime DataNascimento;
        public DadosFisicos Atributos;

        public Pessoa() { }
        public Pessoa(string nome, byte? idade, DateTime dataNascimento, DadosFisicos atributos)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            Atributos = atributos;
        }

    }
}
