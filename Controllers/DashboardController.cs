using Microsoft.AspNetCore.Mvc;

namespace Dashboard_BOK.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
