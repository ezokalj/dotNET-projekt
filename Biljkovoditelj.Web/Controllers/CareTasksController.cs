using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class CareTasksController : Controller
    {
        // GET: /CareTasks
        public IActionResult Index()
        {
            var careTasks = MockRepository.GetCareTasks();
            return View(careTasks);
        }

        // GET: /CareTasks/Details/1
        public IActionResult Details(int id)
        {
            var careTask = MockRepository.GetCareTaskById(id);

            if (careTask == null)
                return NotFound();

            return View(careTask);
        }
    }
}