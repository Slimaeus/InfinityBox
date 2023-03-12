using AutoMapper;
using InfinityBox.Application.Characters;
using InfinityBox.Application.Characters.Commands.CreateCharacter;
using InfinityBox.Application.Characters.Commands.UpdateCharacter;
using InfinityBox.Domain.Entities;

namespace InfinityBox.Application.Common
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Character, CharacterDTO>()
                .ForMember(des => des.Stats, opt => opt.MapFrom(src =>
                    new Dictionary<string, int>(src.CharacterStats.Select(x => new KeyValuePair<string, int>(x.Stat.Type.ToString(), x.Value)))
                ));

            CreateMap<CreateCharacterCommand, Character>();

            CreateMap<UpdateCharacterCommand, Character>()
                .ForAllMembers(options => options.Condition((src, des, srcValue, desValue) => srcValue != null));
        }
    }
}
