
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Machines {

    public Machines(String nom, int capacite) {
        this.Nom = nom;
        this.Capacite = capacite;
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
    public PersonnelCuisine GetProprio() {
        return this.Proprio;
    }

    /// <summary>
    /// Return the name of the machine
    /// </summary>
    public String GetNom() {
        return this.Nom;
    }

    /// <summary>
    /// Set the new prorpio of the machine
    /// </summary>
    /// <param name="proprio"></param>
    public void SetProprio(PersonnelCuisine proprio) {
        this.Proprio = proprio;
    }

    /// <summary>
    /// Set the time of usage of the machine
    /// </summary>
    public void start(int s) {
        if(s == 0)
        {
            this.Debut = DateTime.Now;
            this.DateFin = new DateTime(1900, 1, 1);
            Console.WriteLine(Debut);
            Console.WriteLine(DateFin);
            return;
        }
        else if(s > 0)
        {
            this.Debut = DateTime.Now;
            this.DateFin = Debut.AddSeconds(s);
            return;
        }
        throw new System.ArgumentException("Erreur de paramettre");
    }

    /// <summary>
    /// Return if the machine is busy or not
    /// To do that it take the StartDate and DateFin and make the difference
    /// </summary>
    /// <returns></returns>
    public bool isRunning()
    {
        if(this.DateFin < DateTime.Now)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}