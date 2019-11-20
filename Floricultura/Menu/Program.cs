using System;
using System.Collections;
using System.Collections.Generic;

namespace Floricultura
{
    class Program
    {

        private static void init()
        {
            BancoMock.ListaProduto = new List<Produto>();
            BancoMock.ListaCliente = new List<Cliente>();
            BancoMock.ListaVenda = new List<Venda>();
        }

        static void Main(string[] args)
        {
            init();
            
            int escolha = 0;
            
            BancoMock.ListaCliente = new List<Cliente>();
            BancoMock.ListaVenda = new List<Venda>();
              do
              {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("01 - Cadastrar produto.");
                Console.WriteLine("02 - Cadastrar cliente.");
                Console.WriteLine("03 - Registrar Venda.");
                Console.WriteLine("00 - Sair.");
                Console.WriteLine("-----------------------------------");
                escolha = int.Parse(Console.ReadLine());
                
                  switch (escolha)
                  {
                    case 1:
                        Fachada.CadastrarProduto();
                    break;  
                    case 2:
                        Fachada.CadastrarCliente();
                    break;
                    case 3:
                        Fachada.CadastrarVenda();
                    break;
                    case 0:
                    Console.WriteLine("Volte sempre!");
                    break;
                    default:
                    Console.WriteLine("Digite uma opção válida!");
                    break;
                  }
              } while (escolha != 0);   
          
       
        

        }
    }
}
