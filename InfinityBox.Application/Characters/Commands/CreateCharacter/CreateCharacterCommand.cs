using InfinityBox.Domain.Entities;
using InfinityBox.Infrastructure.Persistence;
using InfinityBox.Infrastructure.SeedData;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Application.Characters.Commands.CreateCharacter
{
    public class CreateCharacterCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseExperience { get; set; }
    }

    public class CreateCharacterCommandHandler : IRequestHandler<CreateCharacterCommand, Unit>
    {
        private readonly ApplicationDbContext _context;

        public CreateCharacterCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateCharacterCommand request, CancellationToken cancellationToken)
        {
            var character = new Character
            {
                Id = await _context.Characters.CountAsync() + 1,
                BaseExperience = request.BaseExperience,
                Name = request.Name,
                Description = request.Description,
            };

            _context.Add(character);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
