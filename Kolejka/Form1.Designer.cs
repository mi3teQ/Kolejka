
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
            this.aktualny_pacjent = new System.Windows.Forms.Label();
            this.wwww1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_badan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_badania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nastepny_pacjent = new System.Windows.Forms.Label();
            this.poprzedni_pacjent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data_badania_poprzedni_pacjent = new System.Windows.Forms.Label();
            this.data_badania_wybrany_pacjent = new System.Windows.Forms.Label();
            this.data_badania_nastepny_pacjent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.podaj_imie.TextChanged += new System.EventHandler(this.podaj_imie_TextChanged);
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
            this.timer1.Interval = 1000;
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
            this.usun_z_kolejki.Location = new System.Drawing.Point(373, 93);
            this.usun_z_kolejki.Name = "usun_z_kolejki";
            this.usun_z_kolejki.Size = new System.Drawing.Size(92, 23);
            this.usun_z_kolejki.TabIndex = 9;
            this.usun_z_kolejki.Text = "Usun z kolejki";
            this.usun_z_kolejki.UseVisualStyleBackColor = true;
            this.usun_z_kolejki.Click += new System.EventHandler(this.usun_z_kolejki_Click);
            // 
            // aktualny_pacjent
            // 
            this.aktualny_pacjent.AutoSize = true;
            this.aktualny_pacjent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aktualny_pacjent.Location = new System.Drawing.Point(588, 319);
            this.aktualny_pacjent.Name = "aktualny_pacjent";
            this.aktualny_pacjent.Size = new System.Drawing.Size(40, 15);
            this.aktualny_pacjent.TabIndex = 10;
            this.aktualny_pacjent.Text = "label1";
            this.aktualny_pacjent.Click += new System.EventHandler(this.label1_Click);
            // 
            // wwww1
            // 
            this.wwww1.Location = new System.Drawing.Point(63, 291);
            this.wwww1.Name = "wwww1";
            this.wwww1.Size = new System.Drawing.Size(234, 23);
            this.wwww1.TabIndex = 11;
            this.wwww1.Text = "button1";
            this.wwww1.UseVisualStyleBackColor = true;
            this.wwww1.Click += new System.EventHandler(this.poprzedni_pacjent_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(63, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imie,
            this.Nazwa_badan,
            this.Data_badania});
            this.dataGridView1.Location = new System.Drawing.Point(588, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(460, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // Nazwa_badan
            // 
            this.Nazwa_badan.HeaderText = "Nazwa_badan";
            this.Nazwa_badan.Name = "Nazwa_badan";
            // 
            // Data_badania
            // 
            this.Data_badania.HeaderText = "Data_badania";
            this.Data_badania.Name = "Data_badania";
            // 
            // nastepny_pacjent
            // 
            this.nastepny_pacjent.AutoSize = true;
            this.nastepny_pacjent.Location = new System.Drawing.Point(588, 351);
            this.nastepny_pacjent.Name = "nastepny_pacjent";
            this.nastepny_pacjent.Size = new System.Drawing.Size(38, 15);
            this.nastepny_pacjent.TabIndex = 15;
            this.nastepny_pacjent.Text = "label1";
            // 
            // poprzedni_pacjent
            // 
            this.poprzedni_pacjent.AutoSize = true;
            this.poprzedni_pacjent.Location = new System.Drawing.Point(588, 291);
            this.poprzedni_pacjent.Name = "poprzedni_pacjent";
            this.poprzedni_pacjent.Size = new System.Drawing.Size(38, 15);
            this.poprzedni_pacjent.TabIndex = 16;
            this.poprzedni_pacjent.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Poprzedni pacjent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wybrany pacjent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nastepny pacjent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data badania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data badania";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data badania";
            // 
            // data_badania_poprzedni_pacjent
            // 
            this.data_badania_poprzedni_pacjent.AutoSize = true;
            this.data_badania_poprzedni_pacjent.Location = new System.Drawing.Point(752, 291);
            this.data_badania_poprzedni_pacjent.Name = "data_badania_poprzedni_pacjent";
            this.data_badania_poprzedni_pacjent.Size = new System.Drawing.Size(38, 15);
            this.data_badania_poprzedni_pacjent.TabIndex = 23;
            this.data_badania_poprzedni_pacjent.Text = "label8";
            // 
            // data_badania_wybrany_pacjent
            // 
            this.data_badania_wybrany_pacjent.AutoSize = true;
            this.data_badania_wybrany_pacjent.Location = new System.Drawing.Point(752, 319);
            this.data_badania_wybrany_pacjent.Name = "data_badania_wybrany_pacjent";
            this.data_badania_wybrany_pacjent.Size = new System.Drawing.Size(38, 15);
            this.data_badania_wybrany_pacjent.TabIndex = 24;
            this.data_badania_wybrany_pacjent.Text = "label8";
            // 
            // data_badania_nastepny_pacjent
            // 
            this.data_badania_nastepny_pacjent.AutoSize = true;
            this.data_badania_nastepny_pacjent.Location = new System.Drawing.Point(752, 348);
            this.data_badania_nastepny_pacjent.Name = "data_badania_nastepny_pacjent";
            this.data_badania_nastepny_pacjent.Size = new System.Drawing.Size(38, 15);
            this.data_badania_nastepny_pacjent.TabIndex = 25;
            this.data_badania_nastepny_pacjent.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 650);
            this.Controls.Add(this.data_badania_nastepny_pacjent);
            this.Controls.Add(this.data_badania_wybrany_pacjent);
            this.Controls.Add(this.data_badania_poprzedni_pacjent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poprzedni_pacjent);
            this.Controls.Add(this.nastepny_pacjent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.wwww1);
            this.Controls.Add(this.aktualny_pacjent);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label aktualny_pacjent;
        private System.Windows.Forms.Button wwww1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_badan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_badania;
        private System.Windows.Forms.Label nastepny_pacjent;
        private System.Windows.Forms.Label poprzedni_pacjent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label data_badania_poprzedni_pacjent;
        private System.Windows.Forms.Label data_badania_wybrany_pacjent;
        private System.Windows.Forms.Label data_badania_nastepny_pacjent;
    }
}

