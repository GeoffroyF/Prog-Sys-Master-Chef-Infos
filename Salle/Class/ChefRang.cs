
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefRang : PersonnelCuisine
{

    public ChefRang(String Nom, String Prenom) : base(Nom, Prenom)
    {
        Rang = null;
    }

    private Rang Rang;

    /// <summary>
    /// The CR bring the clients to the specified table
    /// 
    /// @param Table
    /// </summary>
    public void PlaceClient(Table Table, Clients Clients)
    {
        //Updates table
        Table.SetNombrePersonnes(Clients.GetNBClients());
        Table.SetClients(Clients);

        //Updates clients
        //In the logic of the scenario, the method calls PrendCommande
        this.PrendCommande(Table);

    }

    /// <summary>
    /// Sets the Rang attribute
    /// </summary>
    public void SetRang(Rang Rang)
    {
        this.Rang = Rang;
    }

    /// <summary>
    /// Gets the Rang attribute
    /// </summary>

    public Rang GetRang()
    {
        return this.Rang;
    }

    /// <summary>
    /// Le CR prend la commande d'une table
    /// 
    /// @param Table
    /// </summary>
    public void PrendCommande(Table Table)
    {
        Clients Cli = null;
        string[] Commande = null;

        Cli = Table.GetClients();
        Commande = Cli.GetCommandes();
        //recup commande

        //la transmetre en cuisine  < To Do

        //Apporte pain et eau
        if (Table.GetHasEau() == false)
        {
            Table.SetHasEau(true);
        }

        if (Table.GetHasPain() == false)
        {
            Table.SetHasPain(true);
        }

        //Update the Water Bottle & Bread stock < To Do
    }

}