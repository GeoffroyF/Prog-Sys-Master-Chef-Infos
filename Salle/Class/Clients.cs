using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clients
{
    public Clients(int NBClients, Boolean IsReserved, String Humeur, String[] Commandes)
    {
        this.Humeur = Humeur;
        this.NBClients = NBClients;
        this.IsReserved = IsReserved;
        this.Commandes = Commandes;
        this.Reservation = null;
        this.Servi = false;
    }


    private String Humeur;
    //Presse, trql, autre

    private int NBClients;

    private Boolean IsReserved;

    private Reservation Reservation;

    private String[] Commandes;

    private Boolean Servi;

    /// <summary>
    /// Gets attribute Servi
    /// </summary>
    /// <returns></returns>    
    public Boolean GetServi()
    {
        return this.Servi;
    }

    /// <summary>
    /// Sets attribute Servi
    /// </summary>
    /// <param name="State"></param>
    public void SetServi(Boolean State)
    {
        this.Servi = State;
    }

    /// <summary>
    /// Get attibute Reservation
    /// </summary>
    /// <returns></returns>
    public Reservation GetIsReservation()
    {
        return this.Reservation;
    }

    /// <summary>
    /// Sets attribute Reservation
    /// </summary>
    /// <param name="Resa"></param>
    public void SetIsReservation(Reservation Resa)
    {
        this.Reservation = Resa;
    }

    /// <summary>
    /// Gets attribute IsReserved
    /// </summary>
    /// <returns></returns>
    public Boolean GetIsReserved()
    {
        return this.IsReserved;
    }

    /// <summary>
    /// Sets attribute IsReserved
    /// </summary>
    /// <param name="State"></param>
    public void SetIsReserved(Boolean State)
    {
        this.IsReserved = State;
    }


    /// <summary>
    /// Gets attribute NBClients
    /// </summary>
    /// <returns></returns>
    public int GetNBClients()
    {
        return this.NBClients;
    }

    /// <summary>
    /// Gets attribute Commande
    /// </summary>
    /// <returns></returns>
    public String[] GetCommandes()
    {
        return this.Commandes;
    }
}

