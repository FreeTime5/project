using collections.Data.CollectionModel;
using Microsoft.AspNetCore.Identity;

namespace collections.Services.CollectionManager
{
    public interface ICollectionManager
    {
        Collection[] FindCollectionByTheme(int themeId);

        Task<bool> CreateCollection(IdentityUser user);

        Collection[] GetFiveBiggestCollections();

        Task<bool> DeleteCollectoin(IdentityUser user);

        Task<bool> AddItemToCollection(IdentityUser user);

        Task<bool> DeleteItemFromCollection(IdentityUser user);
        
    }
}
