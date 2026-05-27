using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Core.Models;
using PremiumCalculator.Infrastructure.Services;

namespace PremiumCalculator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PremiumController : ControllerBase
    {
        private readonly PremiumService _service;

        public PremiumController(PremiumService service)
        {
            _service = service;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate(MemberModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var premium = _service.CalculatePremium(model);

                return Ok(premium);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}