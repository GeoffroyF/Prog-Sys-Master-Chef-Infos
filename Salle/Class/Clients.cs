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

    }

    private String Humeur;
    //Presse, trql, autre

    private int NBClients;

    private Boolean IsReserved;

    private Reservation Reservation;

    private String[] Commandes;

    public Reservation GetIsReservation()
    {
        return this.Reservation;
    }

    public void SetIsReservation(Reservation Resa)
    {
        this.Reservation = Resa;
    }
    public Boolean GetIsReserved()
    {
        return this.IsReserved;
    }

    public void SetIsReserved (Boolean State)
    {
        this.IsReserved = State;
    }

    public int GetNBClients()
    {
        return this.NBClients;
    }

    public String[] GetCommandes()
    {
        return this.Commandes;
    }

    //
    //


}

