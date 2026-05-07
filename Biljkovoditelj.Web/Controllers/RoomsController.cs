using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class RoomsController : Controller
    {
        // GET: /Rooms
        public IActionResult Index()
        {
            var rooms = MockRepository.GetRooms();
            return View(rooms);
        }

        // GET: /Rooms/Details/1
        public IActionResult Details(int id)
        {
            var room = MockRepository.GetRooms().FirstOrDefault(r => r.Id == id);

            if (room == null)
                return NotFound();

            return View(room);
        }
    }
}