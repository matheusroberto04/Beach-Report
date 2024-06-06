using Beach_Report.Data;
using Beach_Report.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Beach_Report.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly BeachContext _dataContext;
        public UsuarioController(BeachContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult EfetuarLogin(LoginDTO request)
        {
            var getUser = _dataContext.Usuarios.FirstOrDefault(x => x.UserEmail == request.CPF);
            if (getUser == null)
            {
                return NotFound();
            }
            if (!BCrypt.Net.BCrypt.Verify(request.Password, getUser.PasswordHash))
            {
                return NotFound();
            }
            //if (getUser.IsActive == false)
            //{
            //    getUser.IsActive = true;
            //}
            return RedirectToAction("MenuPage", "Menu");
        }

        public IActionResult CadastroPage()
        {
            return View();
        }

        public IActionResult EfetuarCadastro(CadastroDTO request)
        {
            var findUser = _dataContext.Usuarios.FirstOrDefault(x => x.CPF == request.CPF);
            if (findUser != null)
            {
                return NotFound();
            }

            Usuario newUser = new Usuario
            {
                CPF = request.CPF,
                Nome = request.Nome,
                UserEmail = request.Email,
                Telefone = request.Telefone,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.PasswordHash),
            };

            _dataContext.Usuarios.Add(newUser);
            _dataContext.SaveChanges();

            return RedirectToAction("MenuPage", "Menu");
        }
        public IActionResult PerfilPage(int id)
        {
            //var getUser = _dataContext.Usuarios.Find(id);
            //ViewBag.Usuario = getUser;
            return View();
        }

        public IActionResult EditarPerfil(int id, string newPassword, CadastroDTO request)
        {
            var getUser = _dataContext.Usuarios.Find(id);



            if (BCrypt.Net.BCrypt.Verify(request.PasswordHash, getUser!.PasswordHash))
            {
                getUser.CPF = request.CPF;
                getUser.Nome = request.Nome;
                getUser.Telefone = request.Telefone;
                getUser.UserEmail = request.Email;
                getUser.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            }

            _dataContext.Update(getUser);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage");
        }

        public IActionResult DeletarPerfil(int id)
        {
            var getUser = _dataContext.Usuarios.Find(id);


            //getUser!.IsActive = false;

            _dataContext.Update(getUser);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage");
        }
    }
}
