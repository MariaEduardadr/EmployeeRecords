using Microsoft.AspNetCore.Mvc;
using WebApplicationMongodb.Models;

namespace WebApplicationMongodb.Controllers
{
    public class ContatoController : Controller
    {
        public Contato contato = new Contato();
        public IActionResult Index()
        {
            var contatosList = contato.ObeterContatos();

            return View(contatosList);
        }
    }
}
