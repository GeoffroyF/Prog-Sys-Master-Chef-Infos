
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefSale : PersonnelCuisine {

    private static ChefSale Instance = null;

    /// <summary>s
    /// Constructeur heriter de PersoennelCuisine
    /// </summary>
    public ChefSale() : base("PLASTINA", "Fabien") {
    }


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public ChefSale GetInstance()
    {
        if (Instance == null)
        {
            ChefSale.Instance = new ChefSale();
        }
        return ChefSale.Instance;
    }
}