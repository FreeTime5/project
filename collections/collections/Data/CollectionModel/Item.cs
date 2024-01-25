namespace collections.Data.CollectionModel
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CollectionId { get; set; }
        public string ImageId { get; set; }

        public Item() { }

        public Item(string Id_, string Name_, string CollectionId_, string ImageId_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.CollectionId = CollectionId_;
            this.ImageId = ImageId_;
        }
    }
}
