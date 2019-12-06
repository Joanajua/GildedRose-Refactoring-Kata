using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void NormalItems()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 4 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            var item = Items.First();
            Assert.AreEqual(1, item.SellIn);
            Assert.AreEqual(3, item.Quality);
        }
    }
}
