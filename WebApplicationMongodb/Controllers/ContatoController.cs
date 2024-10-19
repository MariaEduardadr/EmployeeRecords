using Microsoft.AspNetCore.Mvc;
using WebApplicationMongodb.Models;

namespace WebApplicationMongodb.Controllers
{
    public class ContatoController : Controller
    {
        public Contato contato = new Contato();
        public IActionResult Index()
        {
            ViewBag.Texto = "";
            var contatosList = contato.ObeterContatos();

            return View(contatosList);
        }

        public IActionResult ObterContatos(string texto)
        {
            ViewBag.Texto = texto;
            var contatosList = contato.ObeterContatos(texto);

            return View("Views/Contato/Index.cshtml",contatosList);
        }

        public IActionResult MostrarInserir()
        {
            return View("Views/Contato/Adicionar.cshtml");
        }

        public IActionResult Inserir(Contato contato)
        {
            var result = contato.Inserir(contato);
            return RedirectToAction("Index", "Contato");
        }
        public IActionResult MostrarAtualizar(string id)
        {
            var contatos = contato.ObeterContato(id);
            return View("Views/Contato/Alterar.cshtml", contatos);
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

        public IActionResult MostrarExcluir(string id)
        {
            var contatos = contato.ObeterContato(id);
            return View("Views/Contato/Excluir.cshtml", contatos);
        }
    
        public IActionResult Excluir(Contato contato)
        {
            var result = contato.Excluir(contato);
            return RedirectToAction("Index", "Contato");
        }

    }
}
