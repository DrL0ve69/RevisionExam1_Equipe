using Microsoft.AspNetCore.Mvc;
using RevisionExam1_Equipe.Models;
using RevisionExam1_Equipe.Models.ViewModel;

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
            // Récupérer le client
            Client? client = DB_Clients_ViewModel.ListeClients.FirstOrDefault(c => c.NumClient == idClient);
            LivreModel livre1 = new();
            LivreModel livre2 = new();
            LivreModel livre3 = new();
            // Récupérer les livres


            if (client != null) 
            {
                // Créer le panier
                Panier panier = new ();
                panier.Client = client;
                panier.ListePanier = new List<LivreModel>();

                // Ajouter les livres au panier, pourrait être optimisé dans un loop
                if (idLivre1 != null && DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre1) != null)
                {
                    livre1 = DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre1);
                    panier.ListePanier.Add(livre1);
                }

                if (idLivre2 != null && DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre2) != null)
                {
                    livre2 = DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre2);
                    panier.ListePanier.Add(livre2);
                }

                if (idLivre3 != null && DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre3) != null)
                {
                    livre3 = DB_Livres_ViewModel.ListeLivres.FirstOrDefault(l => l.Id == idLivre3);
                    panier.ListePanier.Add(livre3);
                }
                // Passer le panier à la vue
                return View(panier);
            }
            else
            {
                return Content($"Le client ayant le ID:{idClient} n'est pas disponible!");
            }
        }
    }
}
