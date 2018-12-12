
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Serveur : PersonnelCuisine
{

    public Serveur(String Nom, String Prenom) : base(Nom, Prenom)
    {
        Rang = null;
    }

    private Rang Rang;

    /// <summary>
    /// Sets Rang attribute
    /// </summary>
    /// <param name="Rang"></param>
    public void SetRang(Rang Rang)
    {
        this.Rang = Rang;
    }

    /// <summary>
    /// Gets Rang attribute
    /// </summary>
    /// <returns></returns>
    public Rang GetRang()
    {
        return this.Rang;
    }

    /// <summary>
    /// the Serveur brings the dirty dishes to the Presentoire Sale
    /// </summary>

    public void Debarasse(Table table)
    {
        //Transmet aux presentoire salle un nb couvert proportionels a Table.NBpersonnes
    }

    /// <summary>
    /// The Serveur brings desert
    /// @param Commande
    /// </summary>
    public void AmenerSucre(Commande Commande)
    {
        // TODO implement here
    }

    /// <summary>
    /// Serveur brings plate
    /// @param Commande
    /// </summary>
    public void AmenerSale(Commande Commande)
    {
        Table TableAServir = Commande.GetTable();
        Clients ClientsAServir = TableAServir.GetClients();
        ClientsAServir.SetServi(true);
        //Timer (gerer par winform)
    }

    /// <summary>
    /// Serveur
    /// @param Commande
    /// </summary>
    public int Addition()
    {
        //Depending on the command, method returns the amount to be paid
        //Here it alway return 10, to be modified /!\
        return 10;
    }

}