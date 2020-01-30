using ShoppingBasketKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketKata.Models
{
    public class ShoppingBasket : IShoppingBasket
    {
        private readonly List<Item> items;

        public ShoppingBasket()
        {
            this.items = new List<Item>();
        }

        public void AddItem(Item item) => this.items.Add(item);

        public decimal CalculateTotal() => this.items.Select(i => i.Price).Sum();

        public int GetItemsCount() => this.items.Count();

        public bool IsEmpty() => this.items.Any();

        public ItemisedBill GetItemisedBill()
        {
            var itemisedItems = this.items.GroupBy(i => i.ItemType,
                                                    i => i,
                                                    (key, item) => new ItemisedItem
                                                    {
                                                        Item = item.First(),
                                                        Quantity = item.Count()
                                                    }).ToList();


            return new ItemisedBill { ItemisedItems = itemisedItems };
        }
    }
}
