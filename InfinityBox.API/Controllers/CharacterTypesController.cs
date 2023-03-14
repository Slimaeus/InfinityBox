using InfinityBox.Application.CharacterTypes;
using InfinityBox.Application.CharacterTypes.Commands;
using InfinityBox.Application.CharacterTypes.Queries;
using Microsoft.AspNetCore.Mvc;

namespace InfinityBox.API.Controllers
{
    public class CharacterTypesController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<CharacterTypeDTO> Get(int id)
            => await Mediator.Send(new GetCharacterTypeQuery { Id = id });
        [HttpPost]
        public async Task<IActionResult> Post(CreateCharacterTypeCommand request)
        {
            var characterTypeDTO = await Mediator.Send(request);

            return CreatedAtAction(nameof(Get), new { id = characterTypeDTO.Id } , characterTypeDTO);
        }
    }
}
