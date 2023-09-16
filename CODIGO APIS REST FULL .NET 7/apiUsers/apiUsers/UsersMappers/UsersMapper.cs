using apiUsers.Modelos;
using apiUsers.Modelos.Dtos;
using AutoMapper;

namespace apiUsers.UsersMappers
{
    public class UsersMapper : Profile
    {
        public UsersMapper() 
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDatosDto>().ReverseMap();
        }
    }
}