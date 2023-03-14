using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using MediatR;

namespace InfinityBox.Application.Common.BaseClasses
{
    public record BaseCreateEntityCommand<TEntityDTO> : IRequest<TEntityDTO>
    {
    }
    public abstract class BaseCreateEntityCommandHandler<TRequest, TEntity, TEntityDTO> : IRequestHandler<TRequest, TEntityDTO>
        where TRequest : BaseCreateEntityCommand<TEntityDTO>
        where TEntity : class
        where TEntityDTO : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _entityRepository;
        private readonly IMapper _mapper;

        public BaseCreateEntityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _entityRepository = unitOfWork.Repository<TEntity>();
            _mapper = mapper;
        }
        public virtual async Task<TEntityDTO> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);

            _entityRepository.Add(entity);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);

            return _mapper.Map<TEntityDTO>(entity);
        }
    }
}
