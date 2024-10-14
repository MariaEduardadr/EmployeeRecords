using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMongodb.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
        
            return View();
        }
    }
}
