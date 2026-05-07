using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class WateringLogsController : Controller
    {
        // GET: /WateringLogs
        public IActionResult Index()
        {
            var wateringLogs = MockRepository.GetWateringLogs();
            return View(wateringLogs);
        }

        // GET: /WateringLogs/Details/1
        public IActionResult Details(int id)
        {
            var wateringLog = MockRepository.GetWateringLogById(id);

            if (wateringLog == null)
                return NotFound();

            return View(wateringLog);
        }
    }
}