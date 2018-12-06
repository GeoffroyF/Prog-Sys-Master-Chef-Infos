
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Armoire {

    private int Assiettes = 150;

    private int Couverts = 150;

    private int Verres = 150;

    private int JeuCafe = 50;

    private int Serviettes = 150;

    private int Napes = 40;

    private static Armoire Instance;


    /// <summary>
    /// Retourne le nombre d'assietes
    /// </summary>
    public int GetAssiettes() {
        return this.Assiettes;
    }

    /// <summary>
    /// Met a jour le nombre d'assietes
    /// @param int
    /// </summary>
    public void SetAssiettes(int nb) {
        this.Assiettes += nb;
    }

    /// <summary>
    /// Retourne le nombre de Couverts
    /// </summary>
    public int GetCouverts() {
        return this.Couverts;
    }

    /// <summary>
    /// Met a jours le nombre de couverts
    /// @param int
    /// </summary>
    public void SetCouverts(int nb) {
        this.Couverts += nb;
    }

    /// <summary>
    /// Retourne le nombre de verres
    /// </summary>
    public int GetVerres() {
        return this.Verres;
    }

    /// <summary>
    /// @param int
    /// </summary>
    public void SetVerres(int nb) {
        this.Verres += nb;
    }


    /// <summary>
    /// Retourne le nombre de jeu de café
    /// </summary>
    public int GetJeuCafe() {
        return this.JeuCafe;
    }

    /// <summary>
    /// Modifie le nombre de jeu de café
    /// @param int
    /// </summary>
    public  void SetJeuCafe(int nb) {
        this.JeuCafe += nb;
    }

    /// <summary>
    /// Retourne le nombre de serviettes
    /// </summary>
    public int GetServiettes() {
        return this.Serviettes;
    }

    /// <summary>
    /// Met a jour le nombre de serviettes
    /// @param int
    /// </summary>
    public void SetServiettes(int nb) {
        this.Serviettes += nb;
    }

    /// <summary>
    /// Retoutne le nombre de napes
    /// </summary>
    public int GetNapes() {
        return this.Napes;
    }

    /// <summary>
    /// Met a jout le nombre de napes
    /// @param int
    /// </summary>
    public void SetNapes(int nb) {
        this.Napes += nb;
    }

    /// <summary>
    /// Singleton
    /// Retourne l'unique instance
    /// </summary>
    public Armoire GetInstance() {
        if (Instance is null) {
            Instance = new Armoire();
        }
        return Instance;
    }

}