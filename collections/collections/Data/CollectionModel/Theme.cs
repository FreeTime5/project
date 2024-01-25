namespace collections.Data.CollectionModel
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public Theme()
        {
        }

        public Theme(int Id_, string Name_, string NormalizedName_)
        {
            Id = Id_;
            Name = Name_;
            NormalizedName = NormalizedName_;
        }
    }
}
