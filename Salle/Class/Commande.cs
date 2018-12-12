
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commande {

    public Commande(Table Table, String Plat) {
        this.Table = Table;
        this.Plat=Plat;
    }

    private Table Table;

    private String Plat;

    private Boolean EnCours;

    /// <summary>
    ///  Gets the table attribute
    /// </summary>
    /// <returns></returns>
    public Table GetTable() {
        return this.Table;
    }

    /// <summary>
    /// Gets the plats attribute
    /// </summary>
    /// <returns></returns>
    public string GetPlats() {
        return this.Plat;
    }

    /// <summary>
    /// Sets the plats attribute
    /// @param Plat
    /// </summary>
    public void SetPlats(string Plat) {
        this.Plat = Plat;
    }

}