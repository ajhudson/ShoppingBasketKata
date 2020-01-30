using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ShoppingBasketKata.Tests
{
    [TestClass]
    public class ShoppingBasketTests
    {
        private ShoppingBasket basket;

        [TestInitialize]
        public void SetUp()
        {
            basket = new ShoppingBasket();
        }

        [TestMethod]
        public void IfIsEmptyIsCalledThenItReturnsTrue()
        {
            // Arrange

            // Act
            bool result = basket.IsEmpty();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IfAddItemIsCalledThenItemIsAdded()
        {
            // Arrange 
            var item = new Item { Id = 1, ItemType = ItemType.Banana, Price = 1.5M };
            int countBefore = basket.GetItemsCount();

            // Act
            basket.AddItem(item);

            // Assert
            int countAfter = basket.GetItemsCount();
            Assert.AreEqual(0, countBefore);
            Assert.AreEqual(1, countAfter);
        }

        [TestMethod]
        public void IfCalculateTotalIsCalledThenItemsAreAdded()
        {
            // Arrange
            var item1 = new Item { Id = 1, ItemType = ItemType.Banana, Price = 1.5M };
            var item2 = new Item { Id = 2, ItemType = ItemType.MarsBar, Price = 2.5M };

            basket.AddItem(item1);
            basket.AddItem(item2);

            // Act
            decimal result = basket.CalculateTotal();

            // Assert
            Assert.AreEqual(4M, result);
        }

        [TestMethod]
        public void IfGetItemisedBillIsCalledThenItIsReturnedCorrectly()
        {
            // Arrange
            var item1 = new Item { Id = 1, ItemType = ItemType.Banana, Price = 1.5M };
            var item2 = new Item { Id = 2, ItemType = ItemType.MarsBar, Price = 2.5M };
            var item3 = new Item { Id = 3, ItemType = ItemType.Banana, Price = 1.5M };

            basket.AddItem(item1);
            basket.AddItem(item2);
            basket.AddItem(item3);

            // Act
            ItemisedBillModel result = basket.GetItemisedBill();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ItemisedItems.Count());
            Assert.AreEqual(5.5M, result.Total);
        }
    }
}
