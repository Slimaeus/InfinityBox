using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Domain.Entities;
using InfinityBox.Infrastructure.Persistence;
using MediatR;

namespace InfinityBox.Application.Characters.Commands.CreateCharacter
{
    public class CreateCharacterCommand : IRequest<CharacterDTO>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseExperience { get; set; }
    }

    public class CreateCharacterCommandHandler : IRequestHandler<CreateCharacterCommand, CharacterDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public CreateCharacterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _characterRepository = unitOfWork.Repository<Character>();
            _mapper = mapper;
        }
        public async Task<CharacterDTO> Handle(CreateCharacterCommand request, CancellationToken cancellationToken)
        {
            var character = _mapper.Map<Character>(request);

            _characterRepository.Add(character);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);

            return _mapper.Map<CharacterDTO>(character);
        }
    }
}
