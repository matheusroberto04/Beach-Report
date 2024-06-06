using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContatoPage() 
        {
            return View();  
        }

    }
}
