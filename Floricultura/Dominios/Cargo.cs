namespace Floricultura
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
    }
      public enum Nome
    { 
        Balconista,
        Atendente,
        Gerente,
        Estoquista
    }
}