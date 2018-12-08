
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefSucre : PersonnelCuisine {

    private static ChefSucre Instance = null;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private ChefSucre(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom) {
    }


    /// <summary>
    /// Creation and return of the singleton
    /// The first call of this should have two arguments for the First and Last name
    /// </summary>
    public static ChefSucre GetInstance(String nom = null, String prenom = null)
    {
        if (Instance == null)
        {
            if (!(nom is null) && !(prenom is null))
            {
                ChefSucre.Instance = new ChefSucre(nom, prenom);
            }
            else
            {
                ChefSucre.Instance = new ChefSucre();
            }
        }
        return ChefSucre.Instance;
    }
}