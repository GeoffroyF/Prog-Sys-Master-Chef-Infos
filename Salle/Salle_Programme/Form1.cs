using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_Programme
{

    public partial class Form1 : Form
    {
        private MaitreHotel MH;
        private CommisSalle CS;
        private ChefRang CR_1, CR_2, CR_3, CR_4;
        private Serveur SR_1, SR_2, SR_3, SR_4;

        private Table Table_4_Rang1_1, Table_4_Rang1_2, Table_4_Rang1_3, Table_4_Rang1_4;
        private Table[] TB_Rang1;
        private Rang Rang1;
        private Table Table_4_Rang_2_1, Table_4_Rang_2_2, Table_4_Rang_2_3, Table_4_Rang_2_4;
        private Table[] TB_Rang2;
        private Rang Rang2;

        private Carre Carre1;

        private Table Table_8_Rang3_1, Table_4_Rang3_2, Table_8_Rang3_3;

        private Table[] TB_Rang3;
        private Rang Rang3;
        private Table Table_4_Rang_4_1, Table_8_Rang_4_2, Table_4_Rang_4_3;
        private Table[] TB_Rang4;
        private Rang Rang4;

        private Carre Carre2;

        private Salle Salle;
        private PresentoireSalle Presentoire;

        //instanciation salle
        private String[] CMD;
        private Clients Groupe_test;
        private Table Table_test;

        // 1 Groupe client


        public Form1()
        {
            //Instanciation personnelle

            MH = MaitreHotel.GetInstance("Maitre", "Hotel");
            CS = CommisSalle.GetInstance("Commis", "Salle");

            CR_1 = new ChefRang("CR", "1");
            CR_2 = new ChefRang("CR", "2");
            CR_3 = new ChefRang("CR", "3");
            CR_4 = new ChefRang("CR", "4");

            SR_1 = new Serveur("SR", "1");
            SR_2 = new Serveur("SR", "2");
            SR_3 = new Serveur("SR", "3");
            SR_4 = new Serveur("SR", "4");

            //Instanciation Salle

            TB_Rang1 = new Table[4];
            TB_Rang1[0] = Table_4_Rang1_1 = new Table(4, 0);
            TB_Rang1[1] = Table_4_Rang1_2 = new Table(4, 0);
            TB_Rang1[2] = Table_4_Rang1_3 = new Table(4, 0);
            TB_Rang1[3] = Table_4_Rang1_4 = new Table(4, 0);
            Rang1 = new Rang(SR_1, CR_1, TB_Rang1);

            TB_Rang2 = new Table[4];
            TB_Rang2[0] = Table_4_Rang_2_1 = new Table(4, 0);
            TB_Rang2[1] = Table_4_Rang_2_2 = new Table(4, 0);
            TB_Rang2[2] = Table_4_Rang_2_3 = new Table(4, 0);
            TB_Rang2[3] = Table_4_Rang_2_4 = new Table(4, 0);
            Rang2 = new Rang(SR_2, CR_2, TB_Rang2);

            Carre1 = new Carre(Rang1, Rang2);

            TB_Rang3 = new Table[3];
            TB_Rang3[0] = Table_8_Rang3_1 = new Table(8, 0);
            TB_Rang3[1] = Table_4_Rang3_2 = new Table(4, 0);
            TB_Rang3[2] = Table_8_Rang3_3 = new Table(8, 0);
            Rang3 = new Rang(SR_3, CR_3, TB_Rang3);

            TB_Rang4 = new Table[3];
            TB_Rang4[0] = Table_4_Rang_4_1 = new Table(4, 0);
            TB_Rang4[1] = Table_8_Rang_4_2 = new Table(8, 0);
            TB_Rang4[2] = Table_4_Rang_4_3 = new Table(4, 0);
            Rang4 = new Rang(SR_3, CR_3, TB_Rang3);

            Carre2 = new Carre(Rang3, Rang4);

            Presentoire = new PresentoireSalle();
            Salle = Salle.GetInstance(Carre1, Carre2, MH, CS,Presentoire);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciation Groupe Clients
            CMD = new String[2];
            CMD[0] = "Pates";
            CMD[1] = "Pizza";
            Groupe_test = new Clients(2, false, "presse", CMD);

            //Acceuill, Attribution, placement clients & prise de commande
            //Apport eau et pains
            Table_test = MH.AttribueTable(Salle, Groupe_test,false);
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Service 

            //SR_1.AmenerSale();
            Groupe_test.SetServi(true);

            //demmarrer un timer en fn humeur

            //lorsque fin timer

            //SR_1.Debarrasse (Table)
            


        }
    }
}
