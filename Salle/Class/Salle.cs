
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Salle : PresentoireSalle {

    public Salle(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, Salle Instance, PresentoireSalle PresentoireSalle) {

    }

    public Salle(Carre expected_Carre, Carre carre2, MaitreHotel mH, CommisSalle commis, PresentoireSalle presentoire)
    {
    }

    private Carre CarreUn;

    private Carre CarreDeux;

    private MaitreHotel MaitreHotel;

    private CommisSalle Commis;

    private static Salle Instance;

    private PresentoireSalle PresentoireSalle;

    /// <summary>
    /// Renvoie l'attribut CarreUn de type Carre
    /// </summary>


    public Carre GetCarreUn() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'attribut CarreDeux de type Carre
    /// </summary>

    public Carre GetCarreDeux() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'attribut MaitreHotel de MaitreHotel
    /// </summary>
    
    public MaitreHotel GetMaitreHotel() {
        //return Salle.MaitreHotel;
    }

    /// <summary>
    /// Renvoie l'attribut Commis de type CommisSalle 
    /// </summary>

    public CommisSalle GetCommis() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'instance de l'objet (et la cree si necessaire)
    /// </summary>
    
    public PresentoireSalle GetInstance() {
        // TODO implement here
    }

}