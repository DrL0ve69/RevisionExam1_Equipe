using Microsoft.AspNetCore.Mvc;
using RevisionExam1_Equipe.Models;

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
            return View(DB_Livres_ViewModel.listeLivres);
        }
    }
}
