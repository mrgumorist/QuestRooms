using QuestRooms.BLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
namespace QuestRooms.UI.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        private readonly IRoomsService _roomsService;
        private const int itemsPerPage= 16;
        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }
        // GET: City
        public ActionResult Index(int? i=1)
        {
            var rooms = _roomsService.GetAllRooms().ToList().ToPagedList(i??1, itemsPerPage);
            return View(rooms);
        }

        public ActionResult Details(int id)
        {
            //ViewBag.Message = $"{id}";
            return View(_roomsService.GetById(id));
        }
        
    }
}