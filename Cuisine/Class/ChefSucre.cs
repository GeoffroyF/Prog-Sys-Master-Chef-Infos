
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefSucre : PersonnelCuisine {

    private static ChefSucre Instance = null;

    /// <summary>s
    /// Constructeur heriter de PersoennelCuisine
    /// </summary>
    public ChefSucre() : base("PLASTINA", "Fabien") {
    }


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public ChefSucre GetInstance()
    {
        if (Instance == null)
        {
            ChefSucre.Instance = new ChefSucre();
        }
        return ChefSucre.Instance;
    }
}