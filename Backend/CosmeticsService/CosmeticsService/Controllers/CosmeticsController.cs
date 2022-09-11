using CosmeticsService.Model;
using CosmeticsService.Dto;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CosmeticsService.Interfaces;

namespace CosmeticsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CosmeticsController : ControllerBase
    {
        private readonly ILogger<CosmeticsController> _logger;
        private readonly IMapper _mapper;
        private readonly ICosmeticsPersistenceService _cosmeticsPersistenceService;

        public CosmeticsController(ILogger<CosmeticsController> logger, IMapper mapper, ICosmeticsPersistenceService cosmeticsPersistenceService)
        {
            _logger = logger;
            _mapper = mapper;
            _cosmeticsPersistenceService = cosmeticsPersistenceService;
        }

        [HttpGet("{name}")]
        public ActionResult<Product> Get([FromRoute] string name)
        {
            Product? product = _cosmeticsPersistenceService.GetProductByName(name);
            return Ok(product);
        }

        [HttpGet]
        public ActionResult<ICollection<Product>> Get()
        {
            ICollection<Product>? products = _cosmeticsPersistenceService.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            Product? product = this._mapper.Map<Product>(productDto);
            _cosmeticsPersistenceService.AddProduct(product);
            return Ok();
        }

        [HttpPatch]
        public ActionResult Patch([FromBody] ProductDto productDto)
        {
            Product? product = this._mapper.Map<Product>(productDto);
            _cosmeticsPersistenceService.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] string name)
        {
            _cosmeticsPersistenceService.DeleteProduct(name);
            return Ok();
        }
    }
}