using AutoMapper;
using Badil.Application.Features.Auth.DTOs;
using Badil.Application.Features.Auth.Commands;
using Badil.Domain.Entity;

namespace Badil.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, LoginResponse>()
                .ForMember(dest => dest.Token, opt => opt.Ignore());
            
            CreateMap<RegisterCommand, AppUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
