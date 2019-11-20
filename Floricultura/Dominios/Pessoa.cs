namespace Floricultura
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}