using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class PlantsController : Controller
    {
        // GET: /Plants
        public IActionResult Index()
        {
            var plants = MockRepository.GetPlants();
            return View(plants);
        }

        // GET: /Plants/Details/1
        public IActionResult Details(int id)
        {
            var plant = MockRepository.GetPlantById(id);

            if (plant == null)
                return NotFound();

            return View(plant);
        }
    }
}