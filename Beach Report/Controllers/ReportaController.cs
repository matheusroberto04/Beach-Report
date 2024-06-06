using Beach_Report.Data;
using Beach_Report.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class ReportaController : Controller
    {
        private readonly BeachContext _dataContext;
        public ReportaController(BeachContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReportarPage()
        {
            return View();
        }
        public IActionResult CriarReporte(int IdUsuario, ReportarDTO request)
        {
            var reporte = new Reportar
            {
                IdUsuario = IdUsuario,
                DescricaoReportar = request.DescricaoReportar,
                PostDate = DateTime.Now,
            };
            _dataContext.Reportars.Add(reporte);
            _dataContext.SaveChanges();

            return RedirectToAction("ReportarPage", "Reportar");
        }
        public IActionResult EditarReporte(int reportId, ReportarDTO request)
        {
            var findReport = _dataContext.Reportars.Find(reportId);

            findReport.DescricaoReportar = request.DescricaoReportar;

            _dataContext.Reportars.Update(findReport);
            _dataContext.SaveChanges();

            return RedirectToAction("ReportarPage", "Reportar");
        }
        public IActionResult Delete(int id)
        {
            var findReport = _dataContext.Reportars.Find(id);

            _dataContext.Reportars.Remove(findReport);
            _dataContext.SaveChanges();

            return RedirectToAction("ReportarPage", "Reportar");
        }
    }
}
