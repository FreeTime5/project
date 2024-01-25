using collections.Data.CollectionModel;

namespace collections.Models
{
    public class ThemeViewModel
    {
        public Collection[] Collections { get; }

        public ThemeViewModel(Collection[] collections)
        {
            Collections = collections;
        }
    }
}
