using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketKata
{
    public class ItemisedBillModel
    {
        public List<ItemisedItem> ItemisedItems { get; set; }

        public decimal Total
        {
            get => this.ItemisedItems.Select(i => i.Quantity * i.Item.Price).Sum();
        }
    }
}
