
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Salle : PresentoireSalle {

    private Salle(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle) {
    }


    public static Salle Instance
    {
        get
        {
            return Instance;
        }
    }


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
    /// Renvoie l'instance de l'objet (et la cree si necessaire)
    /// </summary>
    
    public PresentoireSalle GetInstance() {
        //si pas d'instance, la méthode la cree
        return this;
    }

}