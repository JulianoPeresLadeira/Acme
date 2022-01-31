namespace Acme.Domain.DTOs
{
    public class Product : DTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
    }
}