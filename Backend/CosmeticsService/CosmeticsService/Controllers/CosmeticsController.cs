using CosmeticsService.Model;
using CosmeticsService.Dto;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace CosmeticsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CosmeticsController : ControllerBase
    {      
        private readonly ILogger<CosmeticsController> _logger;
        private readonly IMapper _mapper;

        public CosmeticsController(ILogger<CosmeticsController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Product> Get([FromQuery]int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody]Product productDto)
        {

            return Ok();
        }
    }
}