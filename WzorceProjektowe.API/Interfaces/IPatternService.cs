using Microsoft.AspNetCore.Mvc;
using WzorceProjektowe.API.Dto;

namespace WzorceProjektowe.API.Interfaces
{
    public interface IPatternService
    {
        public Task<IActionResult> GetPatternById(Guid guid);
        public Task<IActionResult> GetPatternsByType(string type);
        public Task<IActionResult> GetPatternCodeByType(GetPatternCodeByTypeRequestDto request);
    }
}