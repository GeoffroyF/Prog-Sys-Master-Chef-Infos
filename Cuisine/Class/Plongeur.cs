
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plongeur : PersonnelCuisine {

    /// <summary>
    /// Singleton
    /// retourne l'instance si elle est deja crée
    /// sinon crée un instance et la retourne
    /// </summary>
    public Plongeur() {
    }

    private static Plongeur Instance;


    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public void GetInstance() {
        // TODO implement here
    }

}