
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
            this.nazwa_badan_text = new System.Windows.Forms.Label();
            this.wprowadz_nazwe_badan = new System.Windows.Forms.TextBox();
            this.podaj_imie = new System.Windows.Forms.TextBox();
            this.podaj_imie_text = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazwa_badan_text
            // 
            this.nazwa_badan_text.AutoSize = true;
            this.nazwa_badan_text.Location = new System.Drawing.Point(23, 67);
            this.nazwa_badan_text.Name = "nazwa_badan_text";
            this.nazwa_badan_text.Size = new System.Drawing.Size(138, 15);
            this.nazwa_badan_text.TabIndex = 0;
            this.nazwa_badan_text.Text = "Wprowadz nazwe badan:";
            // 
            // wprowadz_nazwe_badan
            // 
            this.wprowadz_nazwe_badan.Location = new System.Drawing.Point(23, 85);
            this.wprowadz_nazwe_badan.Name = "wprowadz_nazwe_badan";
            this.wprowadz_nazwe_badan.Size = new System.Drawing.Size(100, 23);
            this.wprowadz_nazwe_badan.TabIndex = 1;
            // 
            // podaj_imie
            // 
            this.podaj_imie.Location = new System.Drawing.Point(23, 27);
            this.podaj_imie.Name = "podaj_imie";
            this.podaj_imie.Size = new System.Drawing.Size(100, 23);
            this.podaj_imie.TabIndex = 2;
            // 
            // podaj_imie_text
            // 
            this.podaj_imie_text.AutoSize = true;
            this.podaj_imie_text.Location = new System.Drawing.Point(23, 9);
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
            this.data.Size = new System.Drawing.Size(38, 15);
            this.data.TabIndex = 4;
            this.data.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

