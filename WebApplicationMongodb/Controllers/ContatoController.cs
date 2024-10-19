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

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Alterar(string id)
        {
            var contatos = contato.ObeterContato(id);
            return View(contatos);
        }

        public IActionResult Inserir(Contato contato)
        {
            var result = contato.Inserir(contato);
            return RedirectToAction("Index", "Contato");
        }
        public IActionResult Atualizar(Contato contato)
        {
            var result = contato.Atualizar(contato);
            return RedirectToAction("Index", "Contato");
        }

        public IActionResult Visualizar(string id)
        {
            var contatos = contato.ObeterContato(id);
            return View(contatos);
        }

    
    }
}
