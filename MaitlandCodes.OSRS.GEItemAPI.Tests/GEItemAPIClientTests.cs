using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitlandCodes.OSRS.GEItemAPI.Tests
{
    [TestClass]
    public class GEItemAPIClientTests
    {
        [TestMethod]
        public async Task GetCatalogues_Ok()
        {
            var client = new GEItemAPIClientFactory().Create();
            var catalogues = await client.GetCatalogues(Models.ItemCategory.Ammo);

            Assert.IsTrue(catalogues.Alpha.Any());
        }

        [TestMethod]
        public async Task GetItems_Ok()
        {
            var client = new GEItemAPIClientFactory().Create();
            var items = await client.GetItems(Models.ItemCategory.Ammo, "c", 1);

            Assert.IsTrue(items.Items.Any());
        }
    }
}
