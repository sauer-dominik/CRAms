using CRAms.Data.DTOs.Read;
using Microsoft.AspNetCore.Mvc;

namespace CRAms.API.Controllers
{
    // TODO: Implementation just for Demo purposes
    // TODO: Missing authentication and authorization!
    // TODO: Missing input validation!
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{userId}")]
        public async Task<UserDto?> GetUserByIdAsync(Guid userId)
        {
            return new UserDto
            {
                Description = null,
                Id = Guid.NewGuid(),
                Name = "Martin Mueller",
                Role = Data.Enums.Role.Development,
            };
        }
    }
}
