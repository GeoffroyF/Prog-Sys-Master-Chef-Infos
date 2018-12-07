
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stock {

    public Stock() {
    }

    private Ingrediant[] ZoneDanree;

    private Ingrediant[] ChambreFroide;

    private Ingrediant[] Congelo;

    private static Stock Instance;

    /// <summary>
    /// This should return the list of all the ingrediants that are stocked in ZoneDanree
    /// </summary>
    public Ingrediant[] GetZoneDanree() {
        return this.ZoneDanree;
    }

    public Ingrediant[] GetChambreFroide() {
        return this.ChambreFroide;
    }

    public Ingrediant[] GetCongelo() {
        return this.Congelo;
    }

    public Stock GetInstance() {
        if(Instance is null) {
            Instance = new Stock();
        }
        return Instance;
    }

}