
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
            this.zapisz_do_pliku = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazwa_badan_text
            // 
            this.nazwa_badan_text.AutoSize = true;
            this.nazwa_badan_text.Location = new System.Drawing.Point(22, 43);
            this.nazwa_badan_text.Name = "nazwa_badan_text";
            this.nazwa_badan_text.Size = new System.Drawing.Size(138, 15);
            this.nazwa_badan_text.TabIndex = 0;
            this.nazwa_badan_text.Text = "Wprowadz nazwe badan:";
            // 
            // wprowadz_nazwe_badan
            // 
            this.wprowadz_nazwe_badan.Location = new System.Drawing.Point(167, 35);
            this.wprowadz_nazwe_badan.Name = "wprowadz_nazwe_badan";
            this.wprowadz_nazwe_badan.Size = new System.Drawing.Size(211, 23);
            this.wprowadz_nazwe_badan.TabIndex = 1;
            // 
            // podaj_imie
            // 
            this.podaj_imie.Location = new System.Drawing.Point(167, 6);
            this.podaj_imie.Name = "podaj_imie";
            this.podaj_imie.Size = new System.Drawing.Size(211, 23);
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
            this.data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.Location = new System.Drawing.Point(650, 14);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(42, 21);
            this.data.TabIndex = 4;
            this.data.Text = "Data";
            // 
            // wybierz_date
            // 
            this.wybierz_date.Location = new System.Drawing.Point(167, 64);
            this.wybierz_date.Name = "wybierz_date";
            this.wybierz_date.Size = new System.Drawing.Size(211, 23);
            this.wybierz_date.TabIndex = 5;
            // 
            // podaj_date_text
            // 
            this.podaj_date_text.AutoSize = true;
            this.podaj_date_text.Location = new System.Drawing.Point(23, 70);
            this.podaj_date_text.Name = "podaj_date_text";
            this.podaj_date_text.Size = new System.Drawing.Size(137, 15);
            this.podaj_date_text.TabIndex = 6;
            this.podaj_date_text.Text = "Wprowadz date badania:";
            this.podaj_date_text.Click += new System.EventHandler(this.podaj_date_text_Click);
            // 
            // Godzina
            // 
            this.Godzina.AutoSize = true;
            this.Godzina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Godzina.Location = new System.Drawing.Point(650, 35);
            this.Godzina.Name = "Godzina";
            this.Godzina.Size = new System.Drawing.Size(67, 21);
            this.Godzina.TabIndex = 7;
            this.Godzina.Text = "Godzina";
            this.Godzina.Click += new System.EventHandler(this.Godzina_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dodaj_do_kolejki
            // 
            this.dodaj_do_kolejki.Location = new System.Drawing.Point(167, 93);
            this.dodaj_do_kolejki.Name = "dodaj_do_kolejki";
            this.dodaj_do_kolejki.Size = new System.Drawing.Size(113, 23);
            this.dodaj_do_kolejki.TabIndex = 8;
            this.dodaj_do_kolejki.Text = "Dodaj do kolejki";
            this.dodaj_do_kolejki.UseVisualStyleBackColor = true;
            this.dodaj_do_kolejki.Click += new System.EventHandler(this.dodaj_do_kolejki_Click);
            // 
            // usun_z_kolejki
            // 
            this.usun_z_kolejki.Location = new System.Drawing.Point(286, 93);
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
            this.aktualny_pacjent.Location = new System.Drawing.Point(259, 351);
            this.aktualny_pacjent.Name = "aktualny_pacjent";
            this.aktualny_pacjent.Size = new System.Drawing.Size(33, 15);
            this.aktualny_pacjent.TabIndex = 10;
            this.aktualny_pacjent.Text = "Brak";
            this.aktualny_pacjent.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imie,
            this.Nazwa_badan,
            this.Data_badania});
            this.dataGridView1.Location = new System.Drawing.Point(22, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.Width = 150;
            // 
            // Nazwa_badan
            // 
            this.Nazwa_badan.HeaderText = "Nazwa_badan";
            this.Nazwa_badan.Name = "Nazwa_badan";
            this.Nazwa_badan.Width = 150;
            // 
            // Data_badania
            // 
            this.Data_badania.HeaderText = "Data_badania";
            this.Data_badania.Name = "Data_badania";
            // 
            // nastepny_pacjent
            // 
            this.nastepny_pacjent.AutoSize = true;
            this.nastepny_pacjent.Location = new System.Drawing.Point(259, 383);
            this.nastepny_pacjent.Name = "nastepny_pacjent";
            this.nastepny_pacjent.Size = new System.Drawing.Size(30, 15);
            this.nastepny_pacjent.TabIndex = 15;
            this.nastepny_pacjent.Text = "Brak";
            // 
            // poprzedni_pacjent
            // 
            this.poprzedni_pacjent.AutoSize = true;
            this.poprzedni_pacjent.Location = new System.Drawing.Point(259, 323);
            this.poprzedni_pacjent.Name = "poprzedni_pacjent";
            this.poprzedni_pacjent.Size = new System.Drawing.Size(30, 15);
            this.poprzedni_pacjent.TabIndex = 16;
            this.poprzedni_pacjent.Text = "Brak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Poprzedni pacjent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wybrany pacjent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nastepny pacjent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data badania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data badania";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data badania";
            // 
            // data_badania_poprzedni_pacjent
            // 
            this.data_badania_poprzedni_pacjent.AutoSize = true;
            this.data_badania_poprzedni_pacjent.Location = new System.Drawing.Point(423, 323);
            this.data_badania_poprzedni_pacjent.Name = "data_badania_poprzedni_pacjent";
            this.data_badania_poprzedni_pacjent.Size = new System.Drawing.Size(30, 15);
            this.data_badania_poprzedni_pacjent.TabIndex = 23;
            this.data_badania_poprzedni_pacjent.Text = "Brak";
            // 
            // data_badania_wybrany_pacjent
            // 
            this.data_badania_wybrany_pacjent.AutoSize = true;
            this.data_badania_wybrany_pacjent.Location = new System.Drawing.Point(423, 351);
            this.data_badania_wybrany_pacjent.Name = "data_badania_wybrany_pacjent";
            this.data_badania_wybrany_pacjent.Size = new System.Drawing.Size(30, 15);
            this.data_badania_wybrany_pacjent.TabIndex = 24;
            this.data_badania_wybrany_pacjent.Text = "Brak";
            // 
            // data_badania_nastepny_pacjent
            // 
            this.data_badania_nastepny_pacjent.AutoSize = true;
            this.data_badania_nastepny_pacjent.Location = new System.Drawing.Point(423, 380);
            this.data_badania_nastepny_pacjent.Name = "data_badania_nastepny_pacjent";
            this.data_badania_nastepny_pacjent.Size = new System.Drawing.Size(30, 15);
            this.data_badania_nastepny_pacjent.TabIndex = 25;
            this.data_badania_nastepny_pacjent.Text = "Brak";
            // 
            // zapisz_do_pliku
            // 
            this.zapisz_do_pliku.Location = new System.Drawing.Point(22, 323);
            this.zapisz_do_pliku.Name = "zapisz_do_pliku";
            this.zapisz_do_pliku.Size = new System.Drawing.Size(121, 23);
            this.zapisz_do_pliku.TabIndex = 26;
            this.zapisz_do_pliku.Text = "Zapisz do pliku";
            this.zapisz_do_pliku.UseVisualStyleBackColor = true;
            this.zapisz_do_pliku.Click += new System.EventHandler(this.zapisz_do_pliku_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(536, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Aktualna data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(536, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Godzina:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 467);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zapisz_do_pliku);
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
            this.Text = "Kolejka pacjentow";
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_badan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_badania;
        private System.Windows.Forms.Button zapisz_do_pliku;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

