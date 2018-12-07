
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plongeur : PersonnelCuisine {

    private static Plongeur Instance = null;

    /// <summary>s
    /// Constructeur heriter de PersoennelCuisine
    /// </summary>
    public Plongeur(String nom = "BLOUSOT", String prenom = "Eric") : base(nom, prenom) {
    }


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public Plongeur GetInstance(String nom = null, String  prenom = null) {
        if(Instance == null) {
            if(!(nom is null) && !(prenom is null))
            {
                Plongeur.Instance = new Plongeur(nom, prenom);
            } else
            {
                Plongeur.Instance = new Plongeur();
            }
        }
        return Plongeur.Instance;
    }
}