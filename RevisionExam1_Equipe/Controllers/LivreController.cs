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
        public IActionResult TrouverLivre(int id)
        {
            LivreModel? livre = DB_Livres_ViewModel.listeLivres.FirstOrDefault(l => l.Id == id);
            if (livre != null)
            {
                return View(livre);
            }
            else
            {
                return Content($"Le livre ayant le ID:{id} n'est pas disponible!");
            }
        }
    }
}
