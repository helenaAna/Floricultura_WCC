using System;
using System.Collections.Generic;

namespace Floricultura
{
    public class BancoMock
    {
        public static List<Produto> ListaProduto { get; set; }
        public static List<Cliente> ListaCliente { get; set; }
        public static List<Venda> ListaVenda { get; set; }

        public static Produto SelecionarPrduto() 
        {
            string produtos = "Selecione um dos produtos abaixo:\n";

            foreach (Produto p in BancoMock.ListaProduto)
            {
                produtos += p.ProdutoId + " - " + p.Nome + "\n";
            }
            Console.WriteLine(produtos);

            int idSelecionado = int.Parse(Console.ReadLine());
            Produto produtoSelecionado = null;
            do
            {
                foreach (Produto p in BancoMock.ListaProduto)
                {
                    if (p.ProdutoId == idSelecionado)
                    {
                        produtoSelecionado = p;
                    }
                }
                if (produtoSelecionado == null)
                {
                    Console.WriteLine("Nenhum produto válido selecionado, por favor tente novamente!");
                }
            } while (produtoSelecionado == null);

            return produtoSelecionado;
        }

        public static Cliente SelecionarCliente()
        {

            string clientes = "Selecione um dos clientes abaixo:\n";
            foreach (Cliente c in BancoMock.ListaCliente)
            {
                clientes += c.ClienteId + " - " + c.Nome + "\n";
            }

            Cliente clienteSelecionado = null;
            do
            {
                Console.WriteLine(clientes);
                int idClienteSelecionado = int.Parse(Console.ReadLine());

                foreach (Cliente c
                    in BancoMock.ListaCliente)
                {
                    if (c.ClienteId == idClienteSelecionado)
                    {
                        clienteSelecionado = c;
                    }
                }
                if (clienteSelecionado == null)
                {
                    Console.WriteLine("Nenhum cliente válido selecionado, porfavor tente novamente!");
                }
            } while (clienteSelecionado == null);

            return clienteSelecionado;
        }








    }
}