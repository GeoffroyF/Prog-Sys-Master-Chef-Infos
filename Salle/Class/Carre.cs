
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Carre {

    public Carre(Rang RangUn, Rang RangDeux) {
        this.RangUn = RangUn;
        this.RangDeux = RangDeux;
    }

    private Rang RangUn;

    private Rang RangDeux;


    /// <summary>
    /// Sets the RangUn attribute
    /// </summary>

    public Rang GetRangUn() {
        return this.RangUn;
    }

    /// <summary>
    /// Gets the RangDeux attribute
    /// </summary>

    public Rang GetRangDeux() {
        return this.RangDeux;
    }

}