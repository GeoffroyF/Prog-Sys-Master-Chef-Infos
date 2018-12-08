
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefSale : PersonnelCuisine {

    private static ChefSale Instance = null;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private ChefSale(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom)
    {
    }


    /// <summary>
    /// Creation and return of the singleton
    /// The first call of this should have two arguments for the First and Last name
    /// </summary>
    public static ChefSale GetInstance(String nom = null, String prenom = null)
    {
        if (Instance == null)
        {
            if (!(nom is null) && !(prenom is null))
            {
                ChefSale.Instance = new ChefSale(nom, prenom);
            }
            else
            {
                ChefSale.Instance = new ChefSale();
            }
        }
        return ChefSale.Instance;
    }
}