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
    public class CityService : ICityService
    {
        private readonly IGenericRepository<City> _cityRepos;
        private readonly IMapper _mapper;
        public CityService(IGenericRepository<City> cityRepos, IMapper mapper)
        {
            _cityRepos = cityRepos;
            _mapper = mapper;
        }
        public ICollection<CityDto> GetAllCities()
        {
            var cities = _cityRepos.GetAll();
            return _mapper.Map<IEnumerable<City>, ICollection<CityDto>>(cities);
        }
    }
}
