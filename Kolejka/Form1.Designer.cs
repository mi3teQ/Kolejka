
namespace Kolejka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nazwa_badan_text = new System.Windows.Forms.Label();
            this.wprowadz_nazwe_badan = new System.Windows.Forms.TextBox();
            this.podaj_imie = new System.Windows.Forms.TextBox();
            this.podaj_imie_text = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.wybierz_date = new System.Windows.Forms.DateTimePicker();
            this.podaj_date_text = new System.Windows.Forms.Label();
            this.Godzina = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dodaj_do_kolejki = new System.Windows.Forms.Button();
            this.usun_z_kolejki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwa_badan_text
            // 
            this.nazwa_badan_text.AutoSize = true;
            this.nazwa_badan_text.Location = new System.Drawing.Point(23, 43);
            this.nazwa_badan_text.Name = "nazwa_badan_text";
            this.nazwa_badan_text.Size = new System.Drawing.Size(138, 15);
            this.nazwa_badan_text.TabIndex = 0;
            this.nazwa_badan_text.Text = "Wprowadz nazwe badan:";
            // 
            // wprowadz_nazwe_badan
            // 
            this.wprowadz_nazwe_badan.Location = new System.Drawing.Point(167, 35);
            this.wprowadz_nazwe_badan.Name = "wprowadz_nazwe_badan";
            this.wprowadz_nazwe_badan.Size = new System.Drawing.Size(200, 23);
            this.wprowadz_nazwe_badan.TabIndex = 1;
            // 
            // podaj_imie
            // 
            this.podaj_imie.Location = new System.Drawing.Point(167, 6);
            this.podaj_imie.Name = "podaj_imie";
            this.podaj_imie.Size = new System.Drawing.Size(200, 23);
            this.podaj_imie.TabIndex = 2;
            // 
            // podaj_imie_text
            // 
            this.podaj_imie_text.AutoSize = true;
            this.podaj_imie_text.Location = new System.Drawing.Point(23, 14);
            this.podaj_imie_text.Name = "podaj_imie_text";
            this.podaj_imie_text.Size = new System.Drawing.Size(66, 15);
            this.podaj_imie_text.TabIndex = 3;
            this.podaj_imie_text.Text = "Podaj imię:";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(714, 27);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(31, 15);
            this.data.TabIndex = 4;
            this.data.Text = "Data";
            // 
            // wybierz_date
            // 
            this.wybierz_date.Location = new System.Drawing.Point(167, 64);
            this.wybierz_date.Name = "wybierz_date";
            this.wybierz_date.Size = new System.Drawing.Size(200, 23);
            this.wybierz_date.TabIndex = 5;
            // 
            // podaj_date_text
            // 
            this.podaj_date_text.AutoSize = true;
            this.podaj_date_text.Location = new System.Drawing.Point(23, 70);
            this.podaj_date_text.Name = "podaj_date_text";
            this.podaj_date_text.Size = new System.Drawing.Size(69, 15);
            this.podaj_date_text.TabIndex = 6;
            this.podaj_date_text.Text = "Podaj datę: ";
            this.podaj_date_text.Click += new System.EventHandler(this.podaj_date_text_Click);
            // 
            // Godzina
            // 
            this.Godzina.AutoSize = true;
            this.Godzina.Location = new System.Drawing.Point(714, 43);
            this.Godzina.Name = "Godzina";
            this.Godzina.Size = new System.Drawing.Size(50, 15);
            this.Godzina.TabIndex = 7;
            this.Godzina.Text = "Godzina";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dodaj_do_kolejki
            // 
            this.dodaj_do_kolejki.Location = new System.Drawing.Point(254, 93);
            this.dodaj_do_kolejki.Name = "dodaj_do_kolejki";
            this.dodaj_do_kolejki.Size = new System.Drawing.Size(113, 23);
            this.dodaj_do_kolejki.TabIndex = 8;
            this.dodaj_do_kolejki.Text = "Dodaj do kolejki";
            this.dodaj_do_kolejki.UseVisualStyleBackColor = true;
            this.dodaj_do_kolejki.Click += new System.EventHandler(this.dodaj_do_kolejki_Click);
            // 
            // usun_z_kolejki
            // 
            this.usun_z_kolejki.Location = new System.Drawing.Point(254, 261);
            this.usun_z_kolejki.Name = "usun_z_kolejki";
            this.usun_z_kolejki.Size = new System.Drawing.Size(92, 23);
            this.usun_z_kolejki.TabIndex = 9;
            this.usun_z_kolejki.Text = "Usun z kolejki";
            this.usun_z_kolejki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usun_z_kolejki);
            this.Controls.Add(this.dodaj_do_kolejki);
            this.Controls.Add(this.Godzina);
            this.Controls.Add(this.podaj_date_text);
            this.Controls.Add(this.wybierz_date);
            this.Controls.Add(this.data);
            this.Controls.Add(this.podaj_imie_text);
            this.Controls.Add(this.podaj_imie);
            this.Controls.Add(this.wprowadz_nazwe_badan);
            this.Controls.Add(this.nazwa_badan_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwa_badan_text;
        private System.Windows.Forms.TextBox wprowadz_nazwe_badan;
        private System.Windows.Forms.TextBox podaj_imie;
        private System.Windows.Forms.Label podaj_imie_text;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DateTimePicker wybierz_date;
        private System.Windows.Forms.Label podaj_date_text;
        private System.Windows.Forms.Label Godzina;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dodaj_do_kolejki;
        private System.Windows.Forms.Button usun_z_kolejki;
    }
}

