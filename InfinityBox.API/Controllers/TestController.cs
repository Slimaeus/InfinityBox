using InfinityBox.Domain.Entities;
using InfinityBox.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.API.Controllers
{
    public class TestController : BaseApiController
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var characters = _context.Characters;
            var datas = characters.Select(x => new { x.Id, x.Name, stats = x.CharacterStats.Select(s => new { name = s.Stat.Type.ToString(), s.Value, }) });

            return Ok(datas);

        }
    }
}
