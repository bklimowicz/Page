namespace CosmeticsService.Model
{
    public class Product
    {
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public DateTime AddedOn { get; set; }        
    }
}
