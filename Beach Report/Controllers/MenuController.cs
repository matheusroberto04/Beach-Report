using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuPage() 
        {
            return View(); 
        }
    }
}
