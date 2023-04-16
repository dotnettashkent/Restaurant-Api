using AutoMapper;
using Restaurant.Domain.Entities;
using Restaurant.Service.DTOs.Eats;
using Restaurant.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //User
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<User,UserCreationDto>().ReverseMap();
            CreateMap<User,UserUpdateDto>().ReverseMap();
            CreateMap<UserCreationDto,UserUpdateDto>().ReverseMap();

            //Eat
            CreateMap<Eat,EatDto>().ReverseMap();
            CreateMap<Eat,EatCreationDto>().ReverseMap();
            CreateMap<Eat,EatUpdateDto>().ReverseMap();
            CreateMap<EatCreationDto,EatUpdateDto>().ReverseMap();
        }
    }
}
