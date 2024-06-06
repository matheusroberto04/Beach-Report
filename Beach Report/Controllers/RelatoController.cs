using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class RelatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReportarPage() 
        {
            return View();
        }
    }
}
