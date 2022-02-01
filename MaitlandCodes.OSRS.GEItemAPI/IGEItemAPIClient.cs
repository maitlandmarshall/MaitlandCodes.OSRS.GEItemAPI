using MaitlandCodes.OSRS.GEItemAPI.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitlandCodes.OSRS.GEItemAPI
{
    public interface IGEItemAPIClient
    {
        [Get("/catalogue/category.json")]
        Task<CatalogueResult> GetCatalogues([Query] ItemCategory category);

        [Get("/catalogue/items.json")]
        Task<ItemResult> GetItems([Query] ItemCategory category, string alpha, int page = 1);
    }
}
