using collections.Data;
using collections.Data.CollectionModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace collections.Services.CollectionManager.DefaultCollectionManager
{
    public class CollectionManager : ICollectionManager
    {
        public Task<bool> AddItemToCollection(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCollection(IdentityUser user)
        {
            throw new NotImplementedException();


        }

        public Task<bool> DeleteCollectoin(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemFromCollection(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Collection[] FindCollectionByTheme(int themeId)
        {
            using var context = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            var themeModel = context.Themes.Where(x => x.Id == themeId).First();
            return context.Collections.Where(x => x.ThemeId == themeModel.Id).ToArray();

        }

        public Collection[] GetFiveBiggestCollections()
        {
            //using var context = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            //var collectionIds = context.Items.GroupBy(x => x.CollectionId).Select(g => new { Id = g.Key, Count = g.Count() }).Take(5).Select(x => x.Id);
            //List<Collection> collections = new List<Collection>();
            //foreach (var id in collectionIds)
            //{
            //    collections.Add(context.Collections.Find(id)!);
            //}
            //return collections.ToArray();
            throw new NotImplementedException();

        }
    }
}
