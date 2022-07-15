
using System.Linq;
using AutoMapper;
using SocialApp.API.Dtos;
using SocialApp.API.Models;

namespace SocialApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User,UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                opt.MapFrom(
                    src => src.Photos.FirstOrDefault(p => p.IsMain).Url));

            CreateMap<User,UserForDetailedDto>();
            CreateMap<Photo, PhotosForDetailsDTO>();
        }
    }
}