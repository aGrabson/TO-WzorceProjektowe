using Microsoft.AspNetCore.Mvc;

namespace WzorceProjektowe.API.Interfaces
{
    public interface IPatternService
    {
        public Task<IActionResult> GetPatternById(Guid guid);
        public Task<IActionResult> GetPatternsByType(string type);
    }
}