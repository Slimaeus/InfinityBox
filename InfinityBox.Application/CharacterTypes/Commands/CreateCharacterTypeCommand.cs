using AutoMapper;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using InfinityBox.Application.Common.BaseClasses;
using InfinityBox.Domain.Entities;

namespace InfinityBox.Application.CharacterTypes.Commands
{
    public record CreateCharacterTypeCommand(int Id, string Name, string Description) : BaseCreateEntityCommand<CharacterTypeDTO>;
    //public class CreateCharacterTypeCommandHandler : BaseCreateEntityCommandHandler<CharacterType, CharacterTypeDTO>
    //{
    //    public CreateCharacterTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    //    {
    //    }
    //}
    public class CreateCharacterTypeCommandHandler : BaseCreateEntityCommandHandler<CreateCharacterTypeCommand, CharacterType, CharacterTypeDTO>
    {
        public CreateCharacterTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
