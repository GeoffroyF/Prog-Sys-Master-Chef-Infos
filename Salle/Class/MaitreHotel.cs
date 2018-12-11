
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class MaitreHotel : PersonnelCuisine {

    //Cette implementation de singleton n'est pas valable sur plusieurs thread /!\
    private MaitreHotel(String Nom = "NOM", String Prenom = "PRENOM") : base (Nom, Prenom) {
    }

    private static MaitreHotel instance = null;


    //private String Nom;

    //private String Prenom;

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>

    public static MaitreHotel GetInstance(String Nom = null, String Prenom = null)
    {
        if(MaitreHotel.instance == null)
        {
            MaitreHotel.instance = new MaitreHotel(Nom, Prenom);

        }
        return MaitreHotel.instance;

    }


    /// <summary>
    /// Le MH defini la table qui sera attribue aux clients et appelle le Chef de rang pour qu'il amene les clients a la table
    /// </summary>

    public void AttribueTable(Salle Salle,Clients Clients, Reservation TableReserve) {
        //defini la table (si pas de reservation) 
        // si resa (rajouter un if) Table_Attribue = TableReserve.Table

        Carre CarreTemp=null;
        Rang Rangtemp=null;
        Table Table_attribue=null;
        ChefRang CR_Table=null;
        Boolean Table_vide = false;

        int Carre = 1;

        //balaye les differents rang

        while (Table_vide == false)
        {

            switch (Carre)
            {
                case 1:
                    //Rang UN
                    CarreTemp = Salle.GetCarreUn();
                    Rangtemp = CarreTemp.GetRangUn();
                    break;
                case 2:
                    //Rang DEUX
                    //CarreTemp = Salle.GetCarreUn();
                    Rangtemp = CarreTemp.GetRangDeux();
                    break;
                case 3:
                    //Rang TROIS
                    CarreTemp = Salle.GetCarreDeux();
                    Rangtemp = CarreTemp.GetRangUn();
                    break;

                case 4:
                    //Rang QUATRE
                    //CarreTemp = Salle.GetCarreDeux();
                    Rangtemp = CarreTemp.GetRangDeux();
                    break;

                case 5:
                    //pas de table dispo
                    //Message GUI
                    break;
            }


            foreach (Table TBLE in Rangtemp.GetListeTables())
            {
                if (TBLE.GetNombrePersonnes() == 0)
                {
                    Table_vide = true;
                    Table_attribue = TBLE;
                    break;
                }
            }
            Carre ++;
        }

        //Demander au CR concerné 
        CR_Table = Rangtemp.GetChefRang();

        CR_Table.PlaceClient(Table_attribue, Clients);

    }

    /// <summary>
    /// le MH appelle le Chef de rang pour qu'il amene les clients a la table qu'il a reservé
    /// 
    /// @param Reservation
    /// </summary>
    /// 

    /*
    public void AttribueTable() {
    }*/



}