using AutoMapper;
using QuestRooms.BLL.DtoModels;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Image, ImageDto>();
            CreateMap<Street, StreetDto>();
            CreateMap<Adress, AdressDto>();
            CreateMap<Room, RoomDto>();
        }
    }
}
