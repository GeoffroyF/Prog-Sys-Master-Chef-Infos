
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefCuisine : PersonnelCuisine {
    private static ChefCuisine Instance = null;

    /// <summary>s
    /// Constructeur heriter de PersoennelCuisine
    /// </summary>
    public ChefCuisine() : base("BLOUSOT", "Eric")
    {
    }


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public ChefCuisine GetInstance()
    {
        if (Instance == null)
        {
            ChefCuisine.Instance = new ChefCuisine();
        }
        return ChefCuisine.Instance;
    }
}