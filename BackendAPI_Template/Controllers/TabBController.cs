using BackendAPI_Template.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendAPI_Template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TabBController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TabBController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.TabB.ToListAsync();
            return Ok(items);
        }
    }
}
