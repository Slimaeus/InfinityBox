using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Common.Exceptions;
using InfinityBox.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Application.Common.BaseClasses
{
    public record BaseGetEntityQuery<TKey, TEntityDTO>(TKey Id) : IRequest<TEntityDTO>;
    public class BaseGetEntityQueryHandler<TRequest, TKey, TEntity, TEntityDTO> : IRequestHandler<TRequest, TEntityDTO>
        where TRequest : BaseGetEntityQuery<TKey, TEntityDTO>
        where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity> _entityRepository;
        private readonly IMapper _mapper;

        public BaseGetEntityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _entityRepository = unitOfWork.Repository<TEntity>();
            _mapper = mapper;
        }
        public virtual async Task<TEntityDTO> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var query = _entityRepository
                .SingleResultQuery()
                .AndFilter(x => x.Id.Equals(request.Id));

            var entityDTO = await _entityRepository
                .ToQueryable(query)
                .ProjectTo<TEntityDTO>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(cancellationToken);

            if (entityDTO == null) throw new NotFoundException();

            return entityDTO;
        }
    }
}
