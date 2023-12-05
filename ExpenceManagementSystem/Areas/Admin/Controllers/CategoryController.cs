using Microsoft.AspNetCore.Mvc;

namespace ExpenceManagementSystem.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")]
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
