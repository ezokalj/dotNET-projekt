using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class RemindersController : Controller
    {
        // GET: /Reminders
        public IActionResult Index()
        {
            var reminders = MockRepository.GetReminders();
            return View(reminders);
        }

        // GET: /Reminders/Details/1
        public IActionResult Details(int id)
        {
            var reminder = MockRepository.GetReminderById(id);

            if (reminder == null)
                return NotFound();

            return View(reminder);
        }
    }
}