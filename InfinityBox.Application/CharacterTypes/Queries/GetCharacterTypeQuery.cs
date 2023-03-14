using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Common.BaseClasses;
using InfinityBox.Application.Common.Exceptions;
using InfinityBox.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Application.CharacterTypes.Queries
{
    public record GetCharacterTypeQuery(int Id) : BaseGetEntityQuery<int, CharacterTypeDTO>(Id);
    public class GetCharacterTypeQueryHandler : BaseGetEntityQueryHandler<GetCharacterTypeQuery, int, CharacterType, CharacterTypeDTO>
    {
        public GetCharacterTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
    //public class GetCharacterTypeQueryHandler : IRequestHandler<GetCharacterTypeQuery, CharacterTypeDTO>
    //{
    //    private readonly IRepository<CharacterType> _entityRepository;
    //    private readonly IMapper _mapper;

    //    public GetCharacterTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    //    {
    //        _entityRepository = unitOfWork.Repository<CharacterType>();
    //        _mapper = mapper;
    //    }
    //    public virtual async Task<CharacterTypeDTO> Handle(GetCharacterTypeQuery request, CancellationToken cancellationToken)
    //    {
    //        var query = _entityRepository
    //            .SingleResultQuery()
    //            .AndFilter(x => x.Id.Equals(request.Id));

    //        var entityDTO = await _entityRepository
    //            .ToQueryable(query)
    //            .ProjectTo<CharacterTypeDTO>(_mapper.ConfigurationProvider)
    //            .SingleOrDefaultAsync(cancellationToken);

    //        if (entityDTO == null) throw new NotFoundException();

    //        return entityDTO;
    //    }
    //}
}
