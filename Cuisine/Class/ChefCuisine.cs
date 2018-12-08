
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefCuisine : PersonnelCuisine {
    private static ChefCuisine Instance = null;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private ChefCuisine(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom)
    {
    }

    /// <summary>
    /// Creation and return of the singleton
    /// The first call of this should have two arguments for the First and Last name
    /// </summary>
    public static ChefCuisine GetInstance(String nom = null, String prenom = null)
    {
        if (Instance == null)
        {
            if (!(nom is null) && !(prenom is null))
            {
                ChefCuisine.Instance = new ChefCuisine(nom, prenom);
            }
            else
            {
                ChefCuisine.Instance = new ChefCuisine();
            }
        }
        return ChefCuisine.Instance;
    }
}