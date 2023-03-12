using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Domain.Entities;
using MediatR;

namespace InfinityBox.Application.Characters.Commands.UpdateCharacter
{
    public class UpdateCharacterCommand : IRequest
    {
        public int Id { get; set; }
        public int? BaseExperience { get; set; }
        public string ImageUrl { get; set; }
    }
    public class UpdateCharacterCommandHandler : IRequestHandler<UpdateCharacterCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public UpdateCharacterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _characterRepository = unitOfWork.Repository<Character>();
            _mapper = mapper;
        }
        public async Task Handle(UpdateCharacterCommand request, CancellationToken cancellationToken)
        {
            var query = _characterRepository
                .SingleResultQuery()
                .UseQueryTrackingBehavior(Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll)
                .AndFilter(x => x.Id == request.Id);

            var character = await _characterRepository
                .SingleOrDefaultAsync(query, cancellationToken);

            _mapper.Map(request, character);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);
        }
    }
}
