using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cuisine {
    private Armoire Armoire = new Armoire().GetInstance();

    private static Cuisine Instance = null;

    private Stock Stock;

    private Machines[] Machines;

    private Ustenciles Ustenciles;

    private PassePlat PassePlat;

    /// <summary>
    /// Retourne l'amoire
    /// </summary>
    /// <returns></returns>
    public Armoire GetArmoire() {
        return this.Armoire;
    }

    /// <summary>
    /// Retourne l'unique singleton
    /// </summary>
    /// <returns></returns>
    public Cuisine GetInstance() {
        if(Instance is null) {
            Instance = new Cuisine();
        }
        return Instance;
    }


    /// <summary>
    /// Retourne me stock
    /// </summary>
    /// <returns></returns>
    public Stock GetStock() {
        return this.Stock;
    }

    /// <summary>
    /// Retournes le tableau de machine
    /// </summary>
    /// <returns></returns>
    public Machines[] GetMachines() {
        return this.Machines;
    }

    /// <summary>
    /// Retourne les Ustenciles
    /// </summary>
    /// <returns></returns>
    public Ustenciles GetUstenciles() {
        return this.Ustenciles;
    }


    /// <summary>
    /// Retourne le passeplat
    /// </summary>
    /// <returns></returns>
    public PassePlat GetPassePlat() {
        return this.PassePlat;
    }

}