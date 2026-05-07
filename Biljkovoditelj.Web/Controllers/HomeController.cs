using Biljkovoditelj.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Biljkovoditelj.Web.Data;

namespace Biljkovoditelj.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                TotalPlants = MockRepository.GetPlants().Count,
                TotalRooms = MockRepository.GetRooms().Count,
                TotalUsers = MockRepository.GetUsers().Count,
                PendingTasks = MockRepository.GetCareTasks().Count(ct => !ct.IsCompleted),
                RecentReminders = MockRepository.GetReminders().Take(3).ToList(),
                RecentWateringLogs = MockRepository.GetWateringLogs().Take(3).ToList()
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
