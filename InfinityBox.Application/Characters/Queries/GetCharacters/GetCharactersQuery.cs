using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFrameworkCore.Repository.Collections;
using EntityFrameworkCore.Repository.Extensions;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Common.Exceptions;
using InfinityBox.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Application.Characters.Queries.GetCharacters
{
    public class GetCharactersQuery : IRequest<IPagedList<CharacterDTO>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    public class GetCharactersQueryHandler : IRequestHandler<GetCharactersQuery, IPagedList<CharacterDTO>>
    {
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public GetCharactersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _characterRepository = unitOfWork.Repository<Character>();
            _mapper = mapper;
        }
        public async Task<IPagedList<CharacterDTO>> Handle(GetCharactersQuery request, CancellationToken cancellationToken)
        {
            var query = _characterRepository
                .MultipleResultQuery()
                .Page(request.PageIndex, request.PageSize);

            var list = await _characterRepository
                .ToQueryable(query)
                .ProjectTo<CharacterDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken)
                .Then<List<CharacterDTO>, IList<CharacterDTO>>(result => result, cancellationToken)
                .ToPagedListAsync(query.Paging.PageIndex, query.Paging.PageSize, query.Paging.TotalCount, cancellationToken);

            if (list.Count <= 0) throw new NotFoundException();

            return list;
        }
    }
}
