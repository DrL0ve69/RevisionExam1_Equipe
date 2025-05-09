namespace RevisionExam1_Equipe.Models;

public class LivreModel
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public double Prix { get; set; }

    public LivreModel(int id, string titre, double prix)
    {
        Id = id;
        Titre = titre;
        Prix = prix;
    }
}
