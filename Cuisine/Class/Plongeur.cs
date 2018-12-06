
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plongeur : PersonnelCuisine {

    private static Plongeur Instance = null;

    /// <summary>s
    /// Constructeur heriter de PersoennelCuisine
    /// </summary>
    public Plongeur() : base("BLOUSOT", "Eric") {
    }


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public Plongeur GetInstance() {
        if(Instance == null) {
            Plongeur.Instance = new Plongeur();
        }
        return Plongeur.Instance;
    }
}