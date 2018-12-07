
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class CommisSalle : PersonnelCuisine {

    private CommisSalle(String Nom, String Prenom) : base(Nom, Prenom) {
    }

    private static CommisSalle instance = null;


    private String Nom;

    private String Prenom;

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>
    public static CommisSalle GetInstance(String Nom, String Prenom)
    {
        if (CommisSalle.instance == null)
        {
            if (!(Nom is null) && !(Prenom is null))
            {
                CommisSalle.instance = new CommisSalle(Nom, Prenom);

            }
            else
            {
                return CommisSalle.instance;
                //Ici pb argument, la fonction renvoie une instance 'null'
            }
        }
        return CommisSalle.instance;
    }


    /// <summary>
    /// Le commis debarasse
    /// </summary>

    public void Debarasse(Table table) {
    }

    /// <summary>
    /// Le commis amene l'eau
    /// </summary>
    
    public void AmenerEau(Table table) {
    }

    /// <summary>
    /// Le commis ammene du pain
    /// </summary>

    public void AmenerPain(Table table) {
    }

    /// <summary>
    /// Le commis redresse la table
    /// </summary>

    public void DresserTable(Table table) {
        //check si table debarrassé?
    }

}