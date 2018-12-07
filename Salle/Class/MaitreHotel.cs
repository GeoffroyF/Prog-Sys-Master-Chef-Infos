
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class MaitreHotel : PersonnelCuisine {

    //Cette implementation de singleton n'est pas valable sur plusieurs thread /!\
    private MaitreHotel(String Nom, String Prenom) : base (Nom, Prenom) {
    }

    private static MaitreHotel instance = null;


    private String Nom;

    private String Prenom;

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>

    public static MaitreHotel GetInstance(String Nom, String Prenom)
    {
        if(MaitreHotel.instance == null)
        {
            if (!(Nom is null) && !(Prenom is null))
            {
                MaitreHotel.instance = new MaitreHotel(Nom, Prenom);

            }
            else
            {
                return MaitreHotel.instance;
                //Ici pb argument, la fonction renvoie une instance 'null'
            }
        }
        return MaitreHotel.instance;

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