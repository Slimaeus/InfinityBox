using AutoMapper;
using EntityFrameworkCore.Repository.Collections;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Characters.Queries.GetCharacters;
using InfinityBox.Application.Characters;
using InfinityBox.Application.Common.Exceptions;
using InfinityBox.Domain.Entities;
using MediatR;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Repository.Extensions;

namespace InfinityBox.Application.Common.BaseClasses
{
    public class BaseGetEntityListQuery<TEntityDTO> : IRequest<IPagedList<TEntityDTO>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    public class BaseGetEntityListQueryHandler<TEntity, TEntityDTO> : IRequestHandler<BaseGetEntityListQuery<TEntityDTO>, IPagedList<TEntityDTO>>
        where TEntity : class
    {
        private readonly IRepository<TEntity> _characterRepository;
        private readonly IMapper _mapper;

        public BaseGetEntityListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _characterRepository = unitOfWork.Repository<TEntity>();
            _mapper = mapper;
        }
        public async Task<IPagedList<TEntityDTO>> Handle(BaseGetEntityListQuery<TEntityDTO> request, CancellationToken cancellationToken)
        {
            var query = _characterRepository
                .MultipleResultQuery()
                .Page(request.PageIndex, request.PageSize);

            var list = await _characterRepository
                .ToQueryable(query)
                .ProjectTo<TEntityDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken)
                .Then<List<TEntityDTO>, IList<TEntityDTO>>(result => result, cancellationToken)
                .ToPagedListAsync(query.Paging.PageIndex, query.Paging.PageSize, query.Paging.TotalCount, cancellationToken);

            if (list.Count <= 0) throw new NotFoundException();

            return list;
        }
    }
}
