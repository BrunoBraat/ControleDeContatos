using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult ViewIndexContato()
        {
            return View();
        }

        public IActionResult ViewCriarContato()
        {
            return View();
        }

        public IActionResult ViewEditarContato()
        {
            return View();
        }

        public IActionResult ViewConfirmaDeletarContato()
        {
            return View();
        }
    }
}
