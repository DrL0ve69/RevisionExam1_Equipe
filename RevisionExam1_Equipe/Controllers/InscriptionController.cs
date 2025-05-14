using Microsoft.AspNetCore.Mvc;
using RevisionExam1_Equipe.Models;

namespace RevisionExam1_Equipe.Controllers
{
    public class InscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View(DB_Clients_ViewModel.ListeClients);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            int id = client.NumClient;
            string nom = client.Nom;
            string prenom = client.Prenom;
            if (DB_Clients_ViewModel.ListeClients.Any(c => c.NumClient == id))
            {
                return Content($"Le client ayant le ID:{id} existe déjà!");
            }
            else
            {
                DB_Clients_ViewModel.ListeClients.Add(client);
                return RedirectToAction("Index");
            }
            
        }
        public IActionResult Edit() 
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            DB_Clients_ViewModel.ListeClients.RemoveAll(c => c.NumClient == id);
            return View(id);
        }
    }
}
