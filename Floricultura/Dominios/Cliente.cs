using System;

namespace Floricultura
{
    public class Cliente : Pessoa
    {
        public int ClienteId { get; set; }
        public void CadastrarCliente(int id)
        {
            this.ClienteId = id;
            Console.WriteLine("CADASTRO DE PRODUTO");
            Console.WriteLine("Digite o nome do cliente");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do cliente");
            this.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Cpf do cliente");
            this.Cpf = Console.ReadLine();
        }
    }
}