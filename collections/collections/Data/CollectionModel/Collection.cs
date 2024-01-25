using Microsoft.EntityFrameworkCore.Query.Internal;

namespace collections.Data.CollectionModel
{
    public class Collection
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string UserId { get; set; }
        public int ThemeId { get; set; }
        public string ImageId { get; set; }

        public Collection()
        {
        }

        public Collection(string Id_, string Name_, string NormalizedName_, string UserId_, int ThemeId_, string ImageId_)
        {
            Id = Id_;
            Name = Name_;
            NormalizedName = NormalizedName_;
            UserId = UserId_;
            ThemeId = ThemeId_;
            ImageId = ImageId_;
        }
    }
}
