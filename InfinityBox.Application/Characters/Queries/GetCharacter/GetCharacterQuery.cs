using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Common.Exceptions;
using InfinityBox.Domain.Entities;
using InfinityBox.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Application.Characters.Queries.GetCharacter
{
    public record GetCharacterQuery(int Id) : IRequest<CharacterDTO>;

    public class GetCharacterQueryHandler : IRequestHandler<GetCharacterQuery, CharacterDTO>
    {
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public GetCharacterQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _characterRepository = unitOfWork.Repository<Character>();
            _mapper = mapper;
        }
        public async Task<CharacterDTO> Handle(GetCharacterQuery request, CancellationToken cancellationToken)
        {
            var query = _characterRepository
                .SingleResultQuery()
                .AndFilter(x => x.Id == request.Id);

            var characterDTO = await _characterRepository
                .ToQueryable(query)
                .ProjectTo<CharacterDTO>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(cancellationToken);

            if (characterDTO == null) throw new NotFoundException();

            return characterDTO;
        }
    }
}
