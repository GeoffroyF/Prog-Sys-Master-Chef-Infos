
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reservation {

    public Reservation(Boolean Reserved, Table Table, Boolean Matin) {
        Date = DateTime.Now;
    }

    private Boolean Reserved;

    private Table Table;

    //false = Service du Midi
    //True = Service du soir

    private Boolean Matin;

    private DateTime Date;

    /// <summary>
    /// 
    /// </summary>
    
    public Boolean GetReserved() {
        return this.Reserved;
    }

    /// <summary>
    /// @param boolean
    /// </summary>
    
    public void SetReserved(Boolean State) {
        this.Reserved = State;
    }

    /// <summary>
    /// 
    /// </summary>
    
    public Table GetTable() {
        return this.Table;
    }

    /// <summary>
    /// @param Table
    /// </summary>
    public void SetTable(Table Table) {
        this.Table = Table;
    }

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