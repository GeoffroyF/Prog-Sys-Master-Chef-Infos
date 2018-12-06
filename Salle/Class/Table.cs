
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Table : Strategy {

    public Table(int NombreChaises, int NombrePersonnes, Boolean IsReserved, Boolean HasPain, Boolean HasEau) {
        NombreChaises = 4;
        NombrePersonnes = 0;
        IsReserved = false;
        HasPain = false;
        HasEau = false;
    }

    private int NombreChaises;

    private int NombrePersonnes;

    private Boolean IsReserved;

    private Boolean HasPain;

    private Boolean HasEau;

    //private Plat[] Plats;
    //lie a la solution Cuisine

    /// <summary>
    /// 
    /// </summary>
    public int GetNombreChaises() {
        return this.NombreChaises;
    }

    /// <summary>
    /// @param int
    /// </summary>
    public void SetNombreChaises(int Nbchaises) {
        this.NombreChaises = Nbchaises;
    }

    /// <summary>
    /// 
    /// </summary>    
    public int GetNombrePersonnes() {
        return this.NombrePersonnes;
    }

    /// <summary>
    /// @param int
    /// </summary>   
    public void SetNombrePersonnes(int NbPersonnes) {
        this.NombrePersonnes = NbPersonnes;
    }

    /// <summary>
    /// 
    /// </summary>
    public Boolean GetIsReserved() {
        return this.IsReserved;
    }

    /// <summary>
    /// @param boolean
    /// </summary>
    public void SetIsReserved(Boolean State) {
        this.IsReserved =  State;
    }

    public Boolean GetHasPain() {
        return this.HasPain;
    }

    /// <summary>
    /// @param boolean
    /// </summary>
    public void SetHasPain(Boolean State) {
        this.HasPain = State;
    }

    public Boolean GetHasEau() {
        return HasEau;
    }

    /// <summary>
    /// @param boolean
    /// </summary>
    public void SetHasEau(Boolean State) {
        this.HasEau = State;
    }

    /*
    public void GetPlats() {
        // TODO implement here
    }

    /// <summary>
    /// @param Plats
    /// </summary>
    public void SetPlats(void Plats) {
        // TODO implement here
    }*/

}