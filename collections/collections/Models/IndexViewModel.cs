using collections.Data.CollectionModel;
using collections.Services.CollectionManager;
using collections.Services.CollectionManager.DefaultCollectionManager;
using collections.Services.ThemeManager;
using collections.Services.ThemeManager.DefaultThemeManager;

namespace collections.Models
{
    public class IndexViewModel
    {
        public Theme[] Themes { get; set; } = new Theme[0];
        public Collection[] FiveBiggestCollectoins { get; set; }

        public IndexViewModel(ICollectionManager collectionManager, IThemeManager themeManager)
        {
            //Themes = themeManager.GetAllThemes();
            //FiveBiggestCollectoins = collectionManager.GetFiveBiggestCollections();
        }
    }
}
