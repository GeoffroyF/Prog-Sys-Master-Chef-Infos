
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Serveur : PersonnelCuisine {

    public Serveur(String Nom, String Prenom, Rang Rang) : base (Nom, Prenom) {
    }

    private String Nom;

    private String Prenom;

    private Rang Rang;

    public void GetRang() {
        // TODO implement here
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