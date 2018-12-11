using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle
{
    public partial class ChefMaster : Form
    {
        public ChefMaster()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void Arreter_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void SelectDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectDay.SelectedItem == "Midi")
            {
                Seconde.Text = "0";
                Minutes.Text = "0";
                Heures.Text = "12";
                Jour.Text = "0";
            }
            if (SelectDay.SelectedItem == "Soir")
            {
                Seconde.Text = "0";
                Minutes.Text = "0";
                Heures.Text = "19";
                Jour.Text = "0";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int secondInt = Convert.ToInt32(Seconde.Text);
            if (secondInt < 59)
            {
                Seconde.Text = Convert.ToString(secondInt + 1);
            }
            else
            {
                Seconde.Text = "0";
                int minuteInt = Convert.ToInt32(Minutes.Text);
                if (minuteInt < 59)
                {
                    Minutes.Text = Convert.ToString(minuteInt + 1);
                }
                else
                {
                    Minutes.Text = "0";
                    int hourInt = Convert.ToInt32(Heures.Text);
                    if (hourInt < 23)
                    {
                        Heures.Text = Convert.ToString(hourInt + 1);
                    }
                    else
                    {
                        Heures.Text = "0";
                        int dayInt = Convert.ToInt32(Jour.Text);
                        if (dayInt < 7)
                        {
                            Jour.Text = Convert.ToString(dayInt + 1);
                        }
                        else
                        {
                            Jour.Text = "0";
                        }
                    }
                }
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string nbr_client;
            nbr_client = textBox1.Text;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            timer2.Interval = trackBar2.Value;
        }
    }
}
