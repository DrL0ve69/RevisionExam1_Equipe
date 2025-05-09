using Microsoft.AspNetCore.Mvc;

namespace RevisionExam1_Equipe.Controllers
{
    public class LivreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalogue()
        {
            return View();
        }
    }
}
