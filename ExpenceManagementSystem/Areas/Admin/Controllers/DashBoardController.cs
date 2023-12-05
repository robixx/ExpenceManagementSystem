using Microsoft.AspNetCore.Mvc;

namespace ExpenceManagementSystem.Areas.Areas.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Admin")]
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
