using System;
using System.Collections.Generic;
using System.Text;

namespace Floricultura
{
    public   class Fachada
    {
        public static void CadastrarProduto()
        {
            Produto p = new Produto();
            p.cadastrarProduto(BancoMock.ListaProduto.Count + 1);
            BancoMock.ListaProduto.Add(p);
        }

        public static void CadastrarCliente() 
        {
            Cliente c = new Cliente();
            c.CadastrarCliente(BancoMock.ListaCliente.Count + 1);
            BancoMock.ListaCliente.Add(c);
        }


        public static void CadastrarVenda()
        {
            Produto produtoSelecionado = BancoMock.SelecionarPrduto();

            int respUser;

            Venda v = new Venda();
            v.Items = new List<Item>();
            do
            {
                v.Items.Add(CadastrarItem(produtoSelecionado));
                Console.WriteLine("Escolha 1 para adicionar itens ou 0 para sair");
                respUser = int.Parse(Console.ReadLine());
            } while (respUser == 1);

           

            v.Cliente = BancoMock.SelecionarCliente();

            ImprimeCupom(v);

    }

     private static void ImprimeCupom(Venda venda) 
        {
            Console.WriteLine("============================");
            Console.WriteLine("      Venda Finalizada!");
            Console.WriteLine("        CUPOM FISCAL");
            Console.WriteLine("Cliente: "+ venda.Cliente.Nome);
            foreach (Item item in venda.Items) 
            {
                Console.WriteLine("Produto: " + item.Produto.Nome +" Valor: " + item.TotalItem);
            }
            Console.WriteLine("Total: " + venda.TotalVenda);
            Console.WriteLine("============================");
        
        }
    private static Item CadastrarItem(Produto produtoSelecionado) 
        {
            Item i = new Item();
            i.CadastrarItem(produtoSelecionado);
            return i;
        }



    }
}
