using AutoMapper;
using Managment.System.BLL.DTOs.UserDTOs;
using Managment.System.Domain.Entities.UserEntities;
using System.Runtime.CompilerServices;

namespace Managment.System.BLL.Commons;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<User, RegisterDTO>().ReverseMap();
        CreateMap<User, LoginDTO>().ReverseMap();
    }
}
