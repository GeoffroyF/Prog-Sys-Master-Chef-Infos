
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Salle : PresentoireSalle {

    public Salle(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle) {
        //initialisations par défauts
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
        return Instance.CarreUn;
    }

    /// <summary>
    /// Renvoie l'attribut CarreDeux de type Carre
    /// </summary>

    public Carre GetCarreDeux() {
        return Instance.CarreDeux;
    }

    /// <summary>
    /// Renvoie l'attribut MaitreHotel de MaitreHotel
    /// </summary>
    
    public MaitreHotel GetMaitreHotel() {
        return Instance.MaitreHotel;
    }

    /// <summary>
    /// Renvoie l'attribut Commis de type CommisSalle 
    /// </summary>

    public CommisSalle GetCommis() {
        return Instance.Commis;
    }

    /// <summary>
    /// Renvoie l'instance de l'objet (et la cree si necessaire)
    /// </summary>
    
    public PresentoireSalle GetInstance() {
        //si pas d'instance, la méthode la cree
        return this;
    }

}