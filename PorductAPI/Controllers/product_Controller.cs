using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static PorductAPI.DTos;

namespace PorductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class product_Controller : ControllerBase
    {
        private static readonly List<ProductDto> products = new()
        {
            new ProductDto(Guid.NewGuid(), "Termék1",2500,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Termék2",5500,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Termék3",25000,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
        };
    }
}
