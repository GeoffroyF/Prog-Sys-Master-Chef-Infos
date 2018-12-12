
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonnelCuisine {

    public PersonnelCuisine(String Nom , String Prenom) {
        this.Nom = Nom;
        this.Prenom = Prenom;
        IsBusy = false;
    }

    private String Nom;

    private String Prenom;

    private Boolean IsBusy;

    /// <summary>
    /// Gets nom attribute
    /// </summary>
    
    public String GetNom() {
        return this.Nom;
    }

    /// <summary>
    /// Gets Prenom attribute
    /// </summary>
    
    public String GetPrenom() {
        return this.Prenom;
    }

    /// <summary>
    /// Gets IsBusy attribute
    /// </summary>
 
    public Boolean GetIsBusy() {
        return this.IsBusy;
    }

    /// <summary>
    /// Sets IsBusy attribut
    /// @param Boolean
    /// </summary>
    
    public void SetIsBusy(Boolean State) {
        this.IsBusy = State;
    }

}