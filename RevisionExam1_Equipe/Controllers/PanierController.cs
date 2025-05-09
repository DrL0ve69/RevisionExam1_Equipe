using Microsoft.AspNetCore.Mvc;

namespace RevisionExam1_Equipe.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Panier(int idClient, int? idLivre1, int? idLivre2, int? idLivre3)
        {
            return View();
        }
    }
}
