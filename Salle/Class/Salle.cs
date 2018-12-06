
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Salle : PresentoireSalle {

    public Salle() {

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


    public void GetCarreUn() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'attribut CarreDeux de type Carre
    /// </summary>

    public void GetCarreDeux() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'attribut MaitreHotel de MaitreHotel
    /// </summary>
    
    public void GetMaitreHotel() {
        //return Salle.MaitreHotel;
    }

    /// <summary>
    /// Renvoie l'attribut Commis de type CommisSalle 
    /// </summary>

    public void GetCommis() {
        // TODO implement here
    }

    /// <summary>
    /// Renvoie l'instance de l'objet (et la cree si necessaire)
    /// </summary>
    
    public void GetInstance() {
        // TODO implement here
    }

}