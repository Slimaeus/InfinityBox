using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace InfinityBox.API.Controllers
{
    public class AccountController : BaseApiController
    {
        [Authorize]
        [HttpPost]
        public IActionResult Start()
        {
            var userId = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value);

            var bank = new Domain.Entities.UserBank { UserId = userId, Coins = 100 };
            var pocket = new Domain.Entities.UserPocket { UserId = userId, Coins = 100 };


            return Ok();
        }
    }
}
