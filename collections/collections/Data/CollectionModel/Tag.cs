namespace collections.Data.CollectionModel
{
    public class Tag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public Tag()
        {
        }

        public Tag(string Id_, string Name_, string NormalizedName_)
        {
            Id = Id_;
            Name = Name_;
            NormalizedName = NormalizedName_;
        }
    }
}
