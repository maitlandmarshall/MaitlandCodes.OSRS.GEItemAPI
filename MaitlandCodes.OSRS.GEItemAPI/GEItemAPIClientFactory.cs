using Refit;

namespace MaitlandCodes.OSRS.GEItemAPI
{
    public class GEItemAPIClientFactory
    {
        public IGEItemAPIClient Create()
        {
            return RestService.For<IGEItemAPIClient>(
                hostUrl: "https://secure.runescape.com/m=itemdb_oldschool/api",
                settings: new RefitSettings { UrlParameterFormatter = new ItemCategoryAsIntParameterFormatter(),  });
        }
    }
}
