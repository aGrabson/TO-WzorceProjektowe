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
        [HttpPost("GetPatternCodeByName")]
        public async Task<IActionResult> GetPatternCodeByName([FromBody] GetPatternCodeByNameRequestDto request)
        {
            return await _patternService.GetPatternCodeByName(request);
        }
        [HttpPost("DownloadCode")]
        public async Task<IActionResult> DownloadCode([FromBody] DownloadCodeRequestDto request)
        {
            try
            {
                byte[] zipBytes = await _patternService.DownloadCode(request);

                // Return the ZIP file as response
                return File(zipBytes, "application/zip", $"{request.PatternName}.zip");
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return appropriate response
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }
}
