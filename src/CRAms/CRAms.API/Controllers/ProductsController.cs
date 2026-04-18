using CRAms.Data.DTOs.Read;
using CRAms.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRAms.API.Controllers
{
    // TODO: Implementation just for Demo purposes
    // TODO: Missing authentication and authorization!
    // TODO: Missing input validation!
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProductsAsync()
        {
            return Ok(await productService.GetAllProductsAsync());
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductDto?>> GetProductByIdAsync(Guid productId)
        {
            return Ok(await productService.GetProductByIdAsync(productId));
        }

        [HttpGet("{productId}/participants")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetProductParticipants(Guid productId)
        {
            var participants = new List<UserDto>
            {
                new UserDto
                {
                    Description = null,
                    Id = Guid.NewGuid(),
                    Name = "Martin Mueller",
                    Role = Data.Enums.Role.Development,
                },
                new UserDto
                {
                    Description = null,
                    Id = Guid.NewGuid(),
                    Name = "Developer 2",
                    Role = Data.Enums.Role.Development,
                },
                new UserDto
                {
                    Description = null,
                    Id = Guid.NewGuid(),
                    Name = "Evaluator 1",
                    Role = Data.Enums.Role.Assessment,
                },
            };
            return Ok(participants);
        }
    }
}
