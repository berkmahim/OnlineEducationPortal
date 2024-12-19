using AutoMapper;
using EduPortal.DTO.DTOs.AboutDTOs;
using EduPortal.Entity.Entities;

namespace EduPortal.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
