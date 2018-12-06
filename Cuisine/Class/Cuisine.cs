using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cuisine {
    private static Armoire Armoire;

    private static Cuisine Instance;

    private static Stock Stock;

    private static Machines[] Machines;

    private static Ustenciles Ustenciles;

    private static PassePlat PassePlat;

    /// <summary>
    /// Retourne l'amoire
    /// </summary>
    /// <returns></returns>
    public static Armoire GetArmoire() {
        return Armoire;
    }

    /// <summary>
    /// Retourne l'unique singleton
    /// </summary>
    /// <returns></returns>
    public Cuisine GetInstance() {
        return Instance;
    }


    /// <summary>
    /// Retourne me stock
    /// </summary>
    /// <returns></returns>
    public Stock GetStock() {
        return Stock;
    }

    /// <summary>
    /// Retournes le tableau de machine
    /// </summary>
    /// <returns></returns>
    public Machines[] GetMachines() {
        return Machines;
    }

    /// <summary>
    /// Retourne les Ustenciles
    /// </summary>
    /// <returns></returns>
    public Ustenciles GetUstenciles() {
        return Ustenciles;
    }


    /// <summary>
    /// Retourne le passeplat
    /// </summary>
    /// <returns></returns>
    public PassePlat GetPassePlat() {
        return PassePlat;
    }

}