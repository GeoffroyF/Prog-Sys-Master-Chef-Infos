
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class MaitreHotel : PersonnelCuisine {

    private MaitreHotel(String Nom, String Prenom) : base (Nom, Prenom) {
    }

    private String Nom;

    private String Prenom;

    /*
    > Singleton par initialisation unique :

       private static MaitreHotel Instance = new MaitreHotel;

     > Singleton par Methode :

        public static MaitreHotel GetInstance() {
            return Instance;
        }
    */

    // singleton par propriété :
    public static MaitreHotel Instance{
        get
        {
            return Instance;
        }
    }
    


    /// <summary>
    /// Le MH defini la table qui sera attribue aux clients et appelle le Chef de rang pour qu'il amene les clients a la table
    /// </summary>

    public void AttribueTable() {     
    }

    /// <summary>
    /// le MH appelle le Chef de rang pour qu'il amene les clients a la table qu'il a reservé
    /// 
    /// @param Reservation
    /// </summary>
    /// 

    public void AttribueTable(Reservation TableReserve) {
    }

}