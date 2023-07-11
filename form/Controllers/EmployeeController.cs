using Microsoft.AspNetCore.Mvc;
using form.Models;

namespace form.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitForm(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("index");
        }
    }
}
