
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class CommisSalle : PersonnelCuisine
{

    private CommisSalle(String Nom = "NOM", String Prenom = "PRENOM") : base(Nom, Prenom)
    {
    }

    private static CommisSalle instance = null;

    /// <summary>
    /// Unique Instance method
    /// </summary>
    public static CommisSalle GetInstance(String Nom = null, String Prenom = null)
    {
        if (CommisSalle.instance == null)
        {
            CommisSalle.instance = new CommisSalle(Nom, Prenom);
        }
        return CommisSalle.instance;
    }

    /// <summary>
    /// The Commis brings water
    /// </summary>
    public void AmenerEau(Table table)
    {
        table.SetHasEau(true);
        //updates Water bottle stock < To do
        // > create Get & Set methods in Salle & use it with a Salle attribute
    }

    /// <summary>
    /// The commis brings bread
    /// </summary>
    public void AmenerPain(Table table)
    {
        table.SetHasPain(true);
        //updates bread stock < To do
        // > create Get & Set methods in Salle & use it with a Salle attribute
    }

    /// <summary>
    /// Le commis redresse la table
    /// </summary>
    public void DresserTable(Table table)
    {
        //To do :
        //check if table is "debarrassé"
        //brings new 'nappe' & 'couvert'
    }

}