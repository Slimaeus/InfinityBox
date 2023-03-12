using InfinityBox.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfinityBox.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {

        protected ApplicationDbContext Context => HttpContext.RequestServices.GetRequiredService<ApplicationDbContext>();
    }
}
