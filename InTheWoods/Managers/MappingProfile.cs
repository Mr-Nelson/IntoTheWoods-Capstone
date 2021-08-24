using AutoMapper;
using InTheWoods.DataTransferObjects;
using InTheWoods.Models;

namespace InTheWoods.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
            //CreateMap<UserForRegistrationDto, Admin>();
        }
    }
}

