namespace CosmeticsService.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public DateTime AddedOn { get; set; }        
    }
}
