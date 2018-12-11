namespace Salle
{
    partial class ChefMaster
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefMaster));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Commencer = new System.Windows.Forms.Button();
            this.Arreter = new System.Windows.Forms.Button();
            this.SelectDay = new System.Windows.Forms.ComboBox();
            this.Heures = new System.Windows.Forms.TextBox();
            this.Seconde = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Jour = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1586, 675);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Commencer
            // 
            this.Commencer.Location = new System.Drawing.Point(88, 10);
            this.Commencer.Name = "Commencer";
            this.Commencer.Size = new System.Drawing.Size(75, 23);
            this.Commencer.TabIndex = 1;
            this.Commencer.Text = "Start";
            this.Commencer.UseVisualStyleBackColor = true;
            this.Commencer.Click += new System.EventHandler(this.button5_Click);
            // 
            // Arreter
            // 
            this.Arreter.Location = new System.Drawing.Point(183, 10);
            this.Arreter.Name = "Arreter";
            this.Arreter.Size = new System.Drawing.Size(75, 23);
            this.Arreter.TabIndex = 2;
            this.Arreter.Text = "Stop";
            this.Arreter.UseVisualStyleBackColor = true;
            this.Arreter.Click += new System.EventHandler(this.Arreter_Click);
            // 
            // SelectDay
            // 
            this.SelectDay.AutoCompleteCustomSource.AddRange(new string[] {
            "Midi",
            "Soir"});
            this.SelectDay.FormattingEnabled = true;
            this.SelectDay.Items.AddRange(new object[] {
            "Midi",
            "Soir"});
            this.SelectDay.Location = new System.Drawing.Point(440, 12);
            this.SelectDay.Name = "SelectDay";
            this.SelectDay.Size = new System.Drawing.Size(121, 21);
            this.SelectDay.TabIndex = 4;
            this.SelectDay.SelectedIndexChanged += new System.EventHandler(this.SelectDay_SelectedIndexChanged);
            // 
            // Heures
            // 
            this.Heures.Location = new System.Drawing.Point(140, 61);
            this.Heures.Name = "Heures";
            this.Heures.Size = new System.Drawing.Size(23, 20);
            this.Heures.TabIndex = 5;
            this.Heures.Text = "0";
            this.Heures.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Seconde
            // 
            this.Seconde.Location = new System.Drawing.Point(202, 61);
            this.Seconde.Name = "Seconde";
            this.Seconde.Size = new System.Drawing.Size(26, 20);
            this.Seconde.TabIndex = 6;
            this.Seconde.Text = "0";
            this.Seconde.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(169, 61);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(27, 20);
            this.Minutes.TabIndex = 7;
            this.Minutes.Text = "0";
            this.Minutes.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Jour
            // 
            this.Jour.Location = new System.Drawing.Point(105, 61);
            this.Jour.Name = "Jour";
            this.Jour.Size = new System.Drawing.Size(29, 20);
            this.Jour.TabIndex = 8;
            this.Jour.Text = "0";
            this.Jour.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1434, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(1328, 31);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 10;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(301, 36);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(94, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // ChefMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 794);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Jour);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Seconde);
            this.Controls.Add(this.Heures);
            this.Controls.Add(this.SelectDay);
            this.Controls.Add(this.Arreter);
            this.Controls.Add(this.Commencer);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ChefMaster";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Commencer;
        private System.Windows.Forms.Button Arreter;
        private System.Windows.Forms.ComboBox SelectDay;
        private System.Windows.Forms.TextBox Heures;
        private System.Windows.Forms.TextBox Seconde;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Jour;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

