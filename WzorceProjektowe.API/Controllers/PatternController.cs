using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WzorceProjektowe.API.Dto;
using WzorceProjektowe.API.Interfaces;

namespace WzorceProjektowe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatternController : ControllerBase
    {
        private readonly IPatternService _patternService;

        public PatternController(IPatternService patternService)
        {
            _patternService = patternService;
        }

        [HttpPost("GetPatternsByType")]
        public async Task<IActionResult> GetPatternsByType([FromBody]GetPatternByTypeRequestDto type)
        {
            return await _patternService.GetPatternsByType(type.Type);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatternById(Guid guid)
        {
            return await _patternService.GetPatternById(guid);
        }

        [HttpPost("GetPatternCodeByType")]
        public async Task<IActionResult> GetPatternCodeByType([FromBody] GetPatternCodeByTypeRequestDto request)
        {
            return await _patternService.GetPatternCodeByType(request);
        }

    }
}
