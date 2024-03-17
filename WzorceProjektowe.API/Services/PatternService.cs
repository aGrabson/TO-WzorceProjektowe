using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using WzorceProjektowe.API.Data;
using WzorceProjektowe.API.Interfaces;

namespace WzorceProjektowe.API.Services
{
    public class PatternService : IPatternService
    {
        private readonly DataContext _context;

        public PatternService(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetPatternById(Guid guid)
        {
            var pattern = await _context.Patterns.FirstOrDefaultAsync(x => x.Id == guid);
            if (pattern == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(pattern);
        }
        public async Task<IActionResult> GetPatternsByType(string type)
        {
            var patterns = await _context.Patterns.Where(x => x.Type == type).ToListAsync();
            if (patterns == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(patterns);
        }
    }
}
