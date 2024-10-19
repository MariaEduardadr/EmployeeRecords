using Microsoft.AspNetCore.Mvc;
using WebApplicationMongodb.Models;

namespace WebApplicationMongodb.Controllers
{
    public class EmpregadoController : Controller
    {
        public Empregado _empregado = new Empregado();
        public IActionResult Index()
        {
            ViewBag.Texto = "";
            var empregadosList = _empregado.ObterEmpregados();

            return View(empregadosList);
        }

        public IActionResult ObterEmpregados(string texto)
        {
            ViewBag.Texto = texto;
            var empregadosList = _empregado.ObterEmpregados(texto);

            return View("Views/Empregado/Index.cshtml", empregadosList);
        }

        public IActionResult MostrarInserir()
        {
            return View("Views/Empregado/Adicionar.cshtml");
        }

        public IActionResult Inserir(Empregado empregado)
        {
            var result = empregado.Inserir(empregado);
            return RedirectToAction("Index", "Empregado");
        }
        public IActionResult MostrarAtualizar(string id)
        {
            var empregados = _empregado.ObterEmpregado(id);
            return View("Views/Empregado/Alterar.cshtml", empregados);
                       
        }

        public IActionResult Atualizar(Empregado empregado)
        {
            var result = empregado.Atualizar(empregado);
            return RedirectToAction("Index", "Empregado");
        }

        public IActionResult Visualizar(string id)
        {
            var empregado = _empregado.ObterEmpregado(id);
            return View(empregado);
        }

        public IActionResult MostrarExcluir(string id)
        {
            var empregados = _empregado.ObterEmpregado(id);
            return View("Views/Empregado/Excluir.cshtml", empregados);
        }
    
        public IActionResult Excluir(Empregado empregado)
        {
            var result = empregado.Excluir(empregado);
            return RedirectToAction("Index", "Empregado");
        }

    }
}
