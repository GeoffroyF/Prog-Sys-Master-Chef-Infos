using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cuisine {
    private Armoire Armoire = null;

    private static Cuisine Instance = null;

    private Stock Stock;

    private Machines[] Machines;

    private Ustenciles Ustenciles;

    private PassePlat PassePlat;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private Cuisine(Stock stock = null, Machines[] machines = null, Ustenciles ustenciles = null, PassePlat passePlat = null)
    {
        if (!(stock is null) && !(machines is null) && !(ustenciles is null) && !(passePlat is null))
        {
            this.Stock = stock;
            this.Machines = machines;
            this.Ustenciles = ustenciles;
            this.PassePlat = passePlat;
        }
        else
        {
            this.Stock = null;
            this.Machines = null;
            this.Ustenciles = null;
            this.PassePlat = null;
        }
    }

    /// <summary>
    /// Return the Amoire
    /// </summary>
    /// <returns></returns>
    public Armoire GetArmoire() {
        return this.Armoire;
    }

    /// <summary>
    /// Creation and return of the singleton
    /// The first call of this should have two arguments for the First and Last name
    /// </summary>
    public static Cuisine GetInstance(Stock stock = null, Machines[] machines = null, Ustenciles ustenciles = null, PassePlat passePlat = null) {
        if (Instance == null)
        {
            if (!(stock is null) && !(machines is null) && !(ustenciles is null) && !(passePlat is null))
            {
                Cuisine.Instance = new Cuisine(stock, machines, ustenciles, passePlat);
            }
            else
            {
                Cuisine.Instance = new Cuisine();
            }
        }
        return Cuisine.Instance;
    }

    /// <summary>
    /// Return the stock
    /// </summary>
    /// <returns></returns>
    public Stock GetStock() {
        return this.Stock;
    }

    /// <summary>
    /// Return an array with all the machines
    /// </summary>
    /// <returns></returns>
    public Machines[] GetMachines() {
        return this.Machines;
    }

    /// <summary>
    /// Return all the Ustenciles
    /// </summary>
    /// <returns></returns>
    public Ustenciles GetUstenciles() {
        return this.Ustenciles;
    }


    /// <summary>
    /// Return the PassePlat
    /// </summary>
    /// <returns></returns>
    public PassePlat GetPassePlat() {
        return this.PassePlat;
    }

}