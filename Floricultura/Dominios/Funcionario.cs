namespace Floricultura
{
    public class Funcionario : Pessoa
    {
        public int FuncionarioId { get; set; }
        public Cargo Cargo { get; set; }
    }
}