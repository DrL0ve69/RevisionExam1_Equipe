namespace RevisionExam1_Equipe.Models
{
    public class Client
    {
        public int NumClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Client() { }

        public Client(int numClient, string nom, string prenom) 
        {
            NumClient = numClient;
            Nom = nom;
            Prenom = prenom;
        }
    }

    
}
