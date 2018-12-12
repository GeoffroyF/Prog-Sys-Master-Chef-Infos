
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rang {

    public Rang(Serveur Serveur, ChefRang ChefRang, Table[] ListeTables) {
        //default initialisations
        this.Serveur = Serveur;
        this.ChefRang = ChefRang;
        this.ListeTables = ListeTables;
        Serveur.SetRang(this);
        ChefRang.SetRang(this);
    }

    private Serveur Serveur;

    private ChefRang ChefRang;

    private Table[] ListeTables;

    /// <summary>
    /// Gets Serveur attribute
    /// </summary>

    public Serveur GetServeur() {
        return this.Serveur;
    }

    /// <summary>
    /// Gets ChefRang attribute
    /// </summary>

    public ChefRang GetChefRang() {
        return this.ChefRang;
    }

    /// <summary>
    /// Gets ListeTable attribute
    /// </summary>

    public Table[] GetListeTables() {
        return this.ListeTables;
    }

}