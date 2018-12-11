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
    }

    private String Humeur;
    //Presse, trql, autre

    private int NBClients;

    private Boolean IsReserved;

    private String[] Commandes;

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

