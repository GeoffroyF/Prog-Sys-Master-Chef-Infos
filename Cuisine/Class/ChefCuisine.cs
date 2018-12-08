
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
    /// Creation and return of the singleton with args
    /// </summary>
    public static ChefCuisine GetInstance(String nom, String prenom)
    {
        if (Instance == null)
        {
            ChefCuisine.Instance = new ChefCuisine(nom, prenom);
        }
        return ChefCuisine.Instance;
    }

    /// <summary>
    /// Creation and return of the singleton without args
    /// </summary>
    private static ChefCuisine GetInstance()
    {
        if (Instance == null)
        {
            ChefCuisine.Instance = new ChefCuisine();
        }
        return ChefCuisine.Instance;
    }
}