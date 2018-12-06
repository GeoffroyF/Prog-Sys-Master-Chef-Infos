using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cuisine {
    private Armoire Armoire;

    private static Cuisine Instance;

    private Stock Stock;

    private Machines[] Machines;

    private Ustenciles Ustenciles;

    private PassePlat PassePlat;





    /// <summary>
    /// Retourne l'amoire
    /// </summary>
    /// <returns></returns>
    public Armoire GetArmoire() {
        // TODO implement here
    }

    /// <summary>
    /// Retourne l'unique singleton
    /// </summary>
    /// <returns></returns>
    public Cuisine GetInstance() {
        // TODO implement here
    }


    /// <summary>
    /// Retourne me stock
    /// </summary>
    /// <returns></returns>
    public Stock GetStock() {
        // TODO implement here
    }

    /// <summary>
    /// Retournes le tableau de machine
    /// </summary>
    /// <returns></returns>
    public Machines[] GetMachines() {
        // TODO implement here
    }

    /// <summary>
    /// Retourne les Ustenciles
    /// </summary>
    /// <returns></returns>
    public Ustenciles GetUstenciles() {
        // TODO implement here
    }


    /// <summary>
    /// Retourne le passeplat
    /// </summary>
    /// <returns></returns>
    public PassePlat GetPassePlat() {
        // TODO implement here
    }

}