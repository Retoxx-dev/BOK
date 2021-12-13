using Microsoft.AspNetCore.Mvc;

namespace BOK.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
