using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FeedPage() 
        {
            return View(); 
        }
    }
}
