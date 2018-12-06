
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefSucre : PersonnelCuisine {

    /// <summary>
    /// Singleton
    /// retourne l'instance si elle est deja crée
    /// sinon crée un instance et la retourne
    /// </summary>
    public ChefSucre() {
    }

    private static ChefSucre Instance;

    /// <summary>
    /// Retourne l'unique instance
    /// </summary>
    public void GetInstance() {
        // TODO implement here
    }

}