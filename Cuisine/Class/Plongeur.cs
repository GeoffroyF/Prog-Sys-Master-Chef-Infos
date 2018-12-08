
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plongeur : PersonnelCuisine {

    private static Plongeur Instance = null;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private Plongeur(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom) {
    }


    /// <summary>
    /// Creation and return of the singleton
    /// The first call of this should have two arguments for the First and Last name
    /// </summary>
    public static Plongeur GetInstance(String nom = null, String  prenom = null) {
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