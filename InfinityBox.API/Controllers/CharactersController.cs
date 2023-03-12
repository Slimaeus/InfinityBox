using EntityFrameworkCore.Repository.Collections;
using InfinityBox.Application.Characters;
using InfinityBox.Application.Characters.Commands.CreateCharacter;
using InfinityBox.Application.Characters.Commands.DeleteCharacter;
using InfinityBox.Application.Characters.Commands.UpdateCharacter;
using InfinityBox.Application.Characters.Queries.GetCharacter;
using InfinityBox.Application.Characters.Queries.GetCharacters;
using Microsoft.AspNetCore.Mvc;

namespace InfinityBox.API.Controllers
{
    public class CharactersController : BaseApiController
    {
        [HttpGet]
        public async Task<IPagedList<CharacterDTO>> GetCharacters([FromQuery] GetCharactersQuery request)
        {
            return await Mediator.Send(request);
        }
        [HttpGet("{id}")]
        public async Task<CharacterDTO> GetCharacter(int id)
        {
            return await Mediator.Send(new GetCharacterQuery { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromBody] CreateCharacterCommand request)
        {
            var characterDTO = await Mediator.Send(request);

            return CreatedAtAction("CreateCharacter", new { id = characterDTO }, characterDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCharacter(int id, [FromBody] UpdateCharacterCommand request)
        {
            if (id != request.Id) return BadRequest();

            await Mediator.Send(request);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            await Mediator.Send(new DeleteCharacterCommand(id));

            return NoContent();
        }
    }
}
