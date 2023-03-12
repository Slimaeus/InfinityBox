using AutoMapper;
using EntityFrameworkCore.Repository.Interfaces;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Domain.Entities;
using MediatR;

namespace InfinityBox.Application.Characters.Commands.DeleteCharacter
{
    public record DeleteCharacterCommand(int Id) : IRequest { }
    public class DeleteCharacterCommandHandler : IRequestHandler<DeleteCharacterCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public DeleteCharacterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _characterRepository = unitOfWork.Repository<Character>();
            _mapper = mapper;
        }
        public async Task Handle(DeleteCharacterCommand request, CancellationToken cancellationToken)
        {
            await _characterRepository.RemoveAsync(x => x.Id == request.Id, cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);
        }
    }
}
