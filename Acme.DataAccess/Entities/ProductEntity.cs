namespace Acme.DataAccess.Entities
{
    public class ProductEntity : Entity
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
    }
}
