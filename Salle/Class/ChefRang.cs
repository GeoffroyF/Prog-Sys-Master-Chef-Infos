
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefRang : PersonnelCuisine {

    public ChefRang(String Nom, String Prenom, Rang Rang) : base (Nom, Prenom) {
        IsBusy = false;
    }

    private String Nom;

    private String Prenom;

    private Boolean IsBusy;

    private Rang Rang;


    /// <summary>
    /// Le CR place les clients
    /// 
    /// @param Table
    /// </summary>
    public void PlaceClient(Table Table) {
    }

    /// <summary>
    /// 
    /// </summary>
    
    public Rang GetRang() {
        return this.Rang;
    }

    /// <summary>
    /// Le CR prend la commande d'une table
    /// 
    /// @param Table
    /// </summary>
    public void PrendCommande(Table Table) {
    }

}