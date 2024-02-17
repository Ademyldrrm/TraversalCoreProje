using AutoMapper;
using DtoLayer.Dtos.Announcement;
using DtoLayer.Dtos.AppUserDtos;
using DtoLayer.Dtos.ContactDtos;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();
            CreateMap<Announcement, AnnouncementListDto>().ReverseMap();
            CreateMap<Announcement, AnnouncementUpdateDto>().ReverseMap();
            CreateMap<SendContactDto, ContactUs>().ReverseMap();

            CreateMap<AppUserRegiterDto, AppUser>();
            CreateMap<AppUser, AppUserRegiterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

           

            
        }
    }
}
