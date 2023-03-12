using InfinityBox.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InfinityBox.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;

        protected ApplicationDbContext Context => HttpContext.RequestServices.GetRequiredService<ApplicationDbContext>();
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
    }
}
