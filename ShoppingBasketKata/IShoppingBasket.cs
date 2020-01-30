using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketKata
{
    public interface IShoppingBasket
    {
        void AddItem(Item item);

        int GetItemsCount();

        decimal CalculateTotal();

        bool IsEmpty();

        ItemisedBillModel GetItemisedBill();
    }
}
