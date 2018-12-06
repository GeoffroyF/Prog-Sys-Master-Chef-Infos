
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class CommisSalle : PersonnelCuisine {

    private CommisSalle(String Nom, String Prenom) : base(Nom, Prenom) {
    }

    //Singleton par propriété :
    public static MaitreHotel Instance
    {
        get
        {
            return Instance;
        }
    }

    private String Nom;

    private String Prenom;

    /// <summary>
    /// 
    /// </summary>
    
    public CommisSalle GetInstance() {
        return this;
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