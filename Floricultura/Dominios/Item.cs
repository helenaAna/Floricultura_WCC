using System;

namespace Floricultura
{
    public class Item
    {
        public int ItemId { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal TotalItem
        {
            get
            {
                return  Produto.Preco * Quantidade;

                }
               
            }

        public void CadastrarItem(Produto produtoSelecionado)
        {
          
            int qtdeVendaItem;
            do
            {
                Console.WriteLine("Informe a quantidade desejada: \n" + produtoSelecionado.Quantidade + " em estoque \n");
                qtdeVendaItem = int.Parse(Console.ReadLine());
            } while (qtdeVendaItem == 0 || qtdeVendaItem > produtoSelecionado.Quantidade);
            {
                produtoSelecionado.Quantidade = produtoSelecionado.Quantidade - qtdeVendaItem;
            }

            this.Produto = produtoSelecionado;
            this.Quantidade = qtdeVendaItem;
   
        }

    }
}