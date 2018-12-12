using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reservation {

    Class.Strategy _GetterSetter_Reservation;

    public Reservation(Boolean Reserved, Table Table, Boolean Matin) {
        this.Reserved = Reserved;
        this.Table = Table;
        this.Matin = Matin;
        Date = DateTime.Now;
    }

    private Boolean Reserved;

    //L'objet Reservation compose une Table, on l'accede par cette table
    private Table Table;

    //True = Service du Midi
    //false = Service du soir
    private Boolean Matin;

    private DateTime Date;

    /// <summary>
    /// Gets Reserved attribute
    /// </summary>
    
    public Boolean GetReserved() {
        return this.Reserved;
    }

    /// <summary>
    /// @param boolean
    /// Sets Reserved attribute
    /// Check si la table est deja reserve / Change son état egalement
    /// </summary>
    
    public void SetReserved(Boolean State) {
        this.Reserved = State;
    }

    /// <summary>
    /// Gets Table attribute
    /// </summary>
    
    public Table GetTable() {
        //Table Table
        return this.Table;
    }

    /// <summary>
    /// Sets Table attribute
    /// @param Table
    /// </summary>
    public void SetTable(Table Table) {
        this.Table = Table;
    }

    /// <summary>
    /// Gets Matin attribute
    /// </summary>
    
    public Boolean GetMatin() {
        return this.Matin;
    }

    /// <summary>
    /// Sets Matin attribute
    /// @param boolean
    /// </summary>
    
    public void SetMatin(Boolean State) {
        this.Matin = State;
    }

    /// <summary>
    /// QUELLE EST LUTILITE DE CETTE METODE ??
    /// </summary>
  /*  
    public DateTime GetDate() {
        return this.Date;
    }*/

}