
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Salle : PresentoireSalle {

    private Salle(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle) {
    }


    private static Salle instance = null;


    private Carre CarreUn;

    private Carre CarreDeux;

    private MaitreHotel MaitreHotel;

    private CommisSalle Commis;

    

    private PresentoireSalle PresentoireSalle;

    /// <summary>
    /// Renvoie l'attribut CarreUn de type Carre
    /// </summary>

    public Carre GetCarreUn() {
        return this.CarreUn;
    }

    /// <summary>
    /// Renvoie l'attribut CarreDeux de type Carre
    /// </summary>

    public Carre GetCarreDeux() {
        return this.CarreDeux;
    }

    /// <summary>
    /// Renvoie l'attribut MaitreHotel de MaitreHotel
    /// </summary>
    
    public MaitreHotel GetMaitreHotel() {
        return this.MaitreHotel;
    }

    /// <summary>
    /// Renvoie l'attribut Commis de type CommisSalle 
    /// </summary>

    public CommisSalle GetCommis() {
        return this.Commis;
    }

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>
    public static Salle GetInstance(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
    {
        if (Salle.instance == null)
        {
            // Arguments :
            //(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
            if (!(CarreUn is null) && !(CarreDeux is null) && !(MaitreHotel is null) && !(Commis is null) && !(PresentoireSalle is null))
            {
                Salle.instance = new Salle(CarreUn, CarreDeux, MaitreHotel, Commis, PresentoireSalle);

            }
            else
            {
                return Salle.instance;
                //Ici pb argument, la fonction renvoie une instance 'null'
            }
        }
        return Salle.instance;
    }

}