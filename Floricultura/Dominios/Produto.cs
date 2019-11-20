using System;

namespace Floricultura
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade {get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }

        public  void cadastrarProduto(int id)
        {
          
            this.ProdutoId = id;
            Console.WriteLine("CADASTRO DE PRODUTO");
            Console.WriteLine("Digite o nome do produto");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            this.Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto");
            this.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo do produto");
            this.Tipo = Console.ReadLine();

            
        }

    } 
    public enum Tipo 
    { 
        Flor,
        Terra, 
        Substrato, 
        Outros
        
    }  
}