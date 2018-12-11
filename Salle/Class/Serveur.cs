
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Serveur : PersonnelCuisine {

    public Serveur(String Nom, String Prenom) : base (Nom, Prenom) {
        Rang = null;
    }

    //private String Nom;

    //private String Prenom;

    private Rang Rang;

    public void SetRang(Rang Rang)
    {
        this.Rang = Rang;
    }

    public Rang GetRang() {
        return this.Rang;
    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public void AmenerSucre(Commande Commande) {
        // TODO implement here
    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public void AmenerSale(Commande Commande) {
        // TODO implement here
    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public void Addition(Commande Commande) {
        // TODO implement here
    }

}