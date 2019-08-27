using AutoMapper;
using QuestRooms.BLL.DtoModels;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.DAL.Entities;
using QuestRooms.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Implementation
{
    public class RoomsService : IRoomsService
    {

        private readonly IGenericRepository<Room> _cityRepos;
        private readonly IMapper _mapper;
        public RoomsService(IGenericRepository<Room> cityRepos, IMapper mapper)
        {
            _cityRepos = cityRepos;
            _mapper = mapper;
        }
        public ICollection<RoomDto> GetAllRooms()
        {
            var cities = _cityRepos.GetAll().ToList();
            return _mapper.Map<List<Room>, ICollection<RoomDto>>(cities);
        }
    }
}
