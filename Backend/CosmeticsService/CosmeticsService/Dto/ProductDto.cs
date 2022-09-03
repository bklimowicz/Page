namespace CosmeticsService.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ManufacturerDto Manufacturer { get; set; }
        public ProductCategoryDto ProductCategory { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
