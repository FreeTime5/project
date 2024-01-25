using collections.Data;
using Microsoft.EntityFrameworkCore;
using collections.Data.CollectionModel;

namespace collections.Services.ThemeManager.DefaultThemeManager
{
    public class ThemeManager : IThemeManager
    {
        public Theme[] GetAllThemes()
        {
            using var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            var themes = context.Themes.Select(x => x).ToArray();
            return themes;
        }
    }
}
