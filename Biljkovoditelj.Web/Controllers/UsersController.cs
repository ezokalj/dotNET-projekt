using Microsoft.AspNetCore.Mvc;
using Biljkovoditelj.Web.Data;
using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: /Users
        public IActionResult Index()
        {
            var users = MockRepository.GetUsers();
            return View(users);
        }

        // GET: /Users/Details/1
        public IActionResult Details(int id)
        {
            var user = MockRepository.GetUserById(id);

            if (user == null)
                return NotFound();

            return View(user);
        }
    }
}