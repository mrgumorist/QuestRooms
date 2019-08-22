using QuestRooms.BLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        private readonly IRoomsService _roomsService;
        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }
        // GET: City
        public string Index()
        {
            var cities = _roomsService.GetAllRooms();
            return "Hello";
        }
    }
}