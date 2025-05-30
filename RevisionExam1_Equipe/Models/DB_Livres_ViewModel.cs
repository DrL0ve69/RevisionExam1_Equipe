﻿namespace RevisionExam1_Equipe.Models;

public static class DB_Livres_ViewModel
{
    public static List<LivreModel> ListeLivres { get; set; } = new List<LivreModel>() 
    {
        new LivreModel(1, "Le Petit Prince", 10.99),
        new LivreModel(2, "1984", 8.99),
        new LivreModel(3, "Le Meilleur des Mondes", 12.50),
        new LivreModel(4, "Fahrenheit 451", 9.99),
        new LivreModel(5, "La liberté n'est pas une maqrue de yogourt", 30.99),
    };
}
