using System;
using System.Collections.Generic;

namespace Floricultura
{
    public class Venda
    {
        public int VendaId { get; set; }
        public List<Item> Items { get; set; }
        public Cliente Cliente { get; set; }

        public decimal TotalVenda 
        {
            get
            {
                decimal totalVenda = 0;

                foreach (Item i in Items)
                {
                    totalVenda += i.TotalItem;
                }
                return totalVenda;
            }
        
        }



    }

    
}