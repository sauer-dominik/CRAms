using CRAms.Data.DTOs.Read;
using CRAms.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRAms.API.Controllers
{
    // TODO: Implementation just for Demo purposes
    // TODO: Missing authentication and authorization!
    // TODO: Missing input validation!
    [Route("api/[controller]")]
    public class TechnicalGuidelinesController : ControllerBase
    {
        private readonly ITechnicalGuidelineService technicalGuidelineService;

        public TechnicalGuidelinesController(ITechnicalGuidelineService technicalGuidelineService)
        {
            this.technicalGuidelineService = technicalGuidelineService;
        }

        [HttpGet("{technicalGuidelineId}")]
        public async Task<ActionResult<TechnicalGuidelineDto?>> GetTechnicalGuidelineAsync(Guid technicalGuidelineId)
        {
            return Ok(await technicalGuidelineService.GetCurrentTechnicalGuidelineAsync("en"));
        }
    }
}
