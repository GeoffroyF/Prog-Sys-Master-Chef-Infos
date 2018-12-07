
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Machines {

    public Machines() {
    }

    private DateTime Debut;

    private DateTime DateFin;

    private int Capacite;

    private PersonnelCuisine Proprio;

    private String Nom;

    /// <summary>
    /// Function that make the machine run
    /// </summary>
    public void Utilise() {
        // TODO implement here
    }

    /// <summary>
    /// Return the actual person using the machine
    /// </summary>
    public void GetProprio() {
        // TODO implement here
    }

    /// <summary>
    /// Return the name of the machine
    /// </summary>
    public void GetNom() {
        // TODO implement here
    }

    /// <summary>
    /// Set the new prorpio of the machine
    /// </summary>
    /// <param name="proprio"></param>
    public void SetProprio(PersonnelCuisine proprio) {

    }

    /// <summary>
    /// Set the time of usage of the machine
    /// </summary>
    public void start(int s) {

    }

    /// <summary>
    /// Return if the machine is busy or not
    /// To do that it take the StartDate and DateFin and make the difference
    /// </summary>
    /// <returns></returns>
    public bool isRunning()
    {

    }

}