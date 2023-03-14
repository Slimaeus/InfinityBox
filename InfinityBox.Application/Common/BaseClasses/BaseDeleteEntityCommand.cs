using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Domain.Common;
using MediatR;

namespace InfinityBox.Application.Common.BaseClasses
{
    public abstract record BaseDeleteEntityCommand<TKey>(TKey Id) : IRequest;
    public abstract class BaseDeleteEntityCommand<TRequest, TKey, TEntity> : IRequestHandler<TRequest>
        where TRequest : BaseDeleteEntityCommand<TKey>
        where TEntity : class, IBaseEntity<TKey>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _entityRepository;

        public BaseDeleteEntityCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _entityRepository = unitOfWork.Repository<TEntity>();
        }
        public virtual async Task Handle(TRequest request, CancellationToken cancellationToken)
        {
            await _entityRepository.RemoveAsync(x => x.Id.Equals(request.Id), cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);
        }
    }
}
