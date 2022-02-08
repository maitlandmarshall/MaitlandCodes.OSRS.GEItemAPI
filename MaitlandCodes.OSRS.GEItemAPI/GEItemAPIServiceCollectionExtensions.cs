using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace MaitlandCodes.OSRS.GEItemAPI
{
    public static class GEItemAPIServiceCollectionExtensions
    {
        public static IServiceCollection AddGEItemAPI(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors
                .AddRefitClient<IGEItemAPIClient>(new RefitSettings { UrlParameterFormatter = new ItemCategoryAsIntParameterFormatter() })
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://secure.runescape.com/m=itemdb_oldschool/api"));

            return serviceDescriptors;
        }
    }
}
