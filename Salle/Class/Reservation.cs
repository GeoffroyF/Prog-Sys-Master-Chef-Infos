using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reservation {

    Class.Strategy _GetterSetter_Reservation;

    public Reservation(Boolean Reserved, Boolean Matin) {
        Date = DateTime.Now;
    }

    private Boolean Reserved;

    //private Table Table;
    //L'objet Reservation compose une Table, on l'accede par cette table

    //True = Service du Midi
    //false = Service du soir

    private Boolean Matin;

    private DateTime Date;

    /// <summary>
    /// Renvoie 
    /// </summary>
    
    public Boolean GetReserved() {
        return this.Reserved;
    }

    /// <summary>
    /// @param boolean
    /// Change l'etat de la reservation
    /// </summary>
    
    public void SetReserved(Boolean State) {
        this.Reserved = State;
    }

    /*/// <summary>
    /// 
    /// </summary>
    
    public Table GetTable() {
        Table Table
        return Table;
    }*/

    /*/// <summary>
    /// @param Table
    /// </summary>
    public void SetTable(Table Table) {
        this.Table = Table;
    }*/

    /// <summary>
    /// 
    /// </summary>
    
    public Boolean GetMatin() {
        return this.Matin;
    }

    /// <summary>
    /// @param boolean
    /// </summary>
    
    public void SetMatin(Boolean State) {
        this.Matin = State;
    }

    /// <summary>
    /// 
    /// </summary>
    
    public DateTime GetDate() {
        return this.Date;
    }

}