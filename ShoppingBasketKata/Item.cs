using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketKata
{
    public class Item
    {
        public long Id { get; set; }

        public ItemType ItemType { get; set; }

        public decimal Price { get; set; }
    }
}
