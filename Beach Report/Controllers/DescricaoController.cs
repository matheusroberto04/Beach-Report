using Beach_Report.Data;
using Microsoft.AspNetCore.Mvc;
using Beach_Report.DTOs;
using Beach_Report.Models;
namespace Beach_Report.Controllers
{
    public class DescricaoController : Controller
    {
        private readonly BeachContext _context;
        public DescricaoController(BeachContext context)
        {
            _context = context;
        }

        // Método para criar uma nova descrição
        public IActionResult CriarDescricao(int IdUsuario, DescricaoDTO request)
        {
            var descricao = new Descricao
            {
                IdUsuario = IdUsuario,
                DescricaoReportar = request.DescricoesReportar,
                DataDescricao = DateTime.Now,
                ReportarId = request.ReportarId
            };

            _context.Descricoes.Add(descricao);
            _context.SaveChanges();

            return RedirectToAction("PerfilPage", "Usuario");
        }

        // Método para editar uma descrição existente
        public IActionResult EditarDescricao(int id, DescricaoDTO request)
        {
            var findDescricao = _context.Descricoes.Find(id);
            if (findDescricao == null)
            {
                return NotFound();
            }

            findDescricao.DescricaoReportar = request.DescricoesReportar;
            findDescricao.DataDescricao = DateTime.Now; // Atualiza a data para a data atual

            _context.Descricoes.Update(findDescricao);
            _context.SaveChanges();

            return RedirectToAction("PerfilPage", "Usuario");
        }

        // Método para deletar uma descrição
        public IActionResult Delete(int id)
        {
            var findDescricao = _context.Descricoes.Find(id);
            if (findDescricao == null)
            {
                return NotFound();
            }

            _context.Descricoes.Remove(findDescricao);
            _context.SaveChanges();

            return RedirectToAction("PerfilPage", "Usuario");
        }
    }
}
