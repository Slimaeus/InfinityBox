using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Domain.Common;
using MediatR;

namespace InfinityBox.Application.Common.BaseClasses
{
    public abstract class BaseUpdateEntityCommand<TKey> : IRequest
    {
        public TKey Id { get; set; }
    }
    public abstract class BaseUpdateEntityCommandHandler<TRequest, TKey, TEntity> : IRequestHandler<TRequest>
        where TRequest : BaseUpdateEntityCommand<TKey>
        where TEntity : class, IBaseEntity<TKey>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _entityRepository;
        private readonly IMapper _mapper;

        public BaseUpdateEntityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _entityRepository = unitOfWork.Repository<TEntity>();
            _mapper = mapper;
        }
        public virtual async Task Handle(TRequest request, CancellationToken cancellationToken)
        {
            var query = _entityRepository
                .SingleResultQuery()
                .UseQueryTrackingBehavior(Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll)
                .AndFilter(x => x.Id.Equals(request.Id));

            var character = await _entityRepository
                .SingleOrDefaultAsync(query, cancellationToken);

            _mapper.Map(request, character);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);
        }
    }
}
