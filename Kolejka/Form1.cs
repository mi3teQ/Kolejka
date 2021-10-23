using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kolejka

{
    public partial class Form1 : Form
    {

        public static Queue<string> kolejkapacjent;
        //Queue kolejkapacjent = new Queue();
        string nazwa;
        string nazwa_badania;
        DateTime dataa;
        int liczba_dni;

        public Form1()
        {
            InitializeComponent();
            kolejkapacjent = new Queue<string>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            data.Text = DateTime.Now.ToString("d/M/yyyy");
            Godzina.Text = DateTime.Now.ToString("t");


        }

        private void podaj_date_text_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_do_kolejki_Click(object sender, EventArgs e)
        {
            nazwa = podaj_imie.Text;
            nazwa_badania = wprowadz_nazwe_badan.Text;
            string dataa = wybierz_date.Value.ToString("dd.MM.yyyy");
            //kolejkapacjent.Enqueue(podaj_imie.ToString());

            //aktualny_pacjent.Text = kolejkapacjent.Peek();


            //foreach (Object obj in kolejkapacjent)
            // { 
            //  aktualny_pacjent.Text = (obj.ToString());
            // }

            // int i = kolejkapacjent.Count;


            // label1.Text = i.ToString();


            dataGridView1.Rows.Add(nazwa, nazwa_badania, dataa);
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);

        }


        private void usun_z_kolejki_Click(object sender, EventArgs e)
        {
            //kolejkapacjent.Dequeue();

            if (this.dataGridView1.SelectedRows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                poprzedni_pacjent.Text = ("Brak");
                data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                data_badania_poprzedni_pacjent.Text = ("Brak");
                aktualny_pacjent.Text = ("Brak");
                data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                data_badania_wybrany_pacjent.Text = ("Brak");
                nastepny_pacjent.Text = ("Brak");
                data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                data_badania_nastepny_pacjent.Text = ("Brak");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void podaj_imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void poprzedni_pacjent_Click(object sender, EventArgs e)
        {






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (dataGridView1.CurrentCell.RowIndex >= 1 )
             {
                 poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();


                 liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                 if (liczba_dni < 0)
                 {
                     data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                     data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                     int liczbadni2 = System.Math.Abs(liczba_dni);
                     data_badania_poprzedni_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                     //ustawic kursywy pogrubiona w labelce 
                 }
                 if(liczba_dni == 0)
                 {
                     data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                     data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                     data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                     //na czerwono dzisiaj
                 }
                 if(liczba_dni > 0){
                     data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                     data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                     data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                     //kursywa
                 }

                 //data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

             }
             else
             {
                 poprzedni_pacjent.Text = ("Brak");
                 data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                 data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                 data_badania_poprzedni_pacjent.Text = ("Brak");
             }

             aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
             liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index ].Cells[2].Value)).Days;

             if (liczba_dni < 0)
             {
                 data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                 data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                 int liczbadni2 = System.Math.Abs(liczba_dni);
                 data_badania_wybrany_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                 //ustawic kursywy pogrubiona w labelce 
             }
             if (liczba_dni == 0)
             {
                 data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                 data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                 data_badania_wybrany_pacjent.Text = ("Dzisiaj");
                 //na czerwono dzisiaj
             }
             if (liczba_dni > 0)
             {
                 data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                 data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                 data_badania_wybrany_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                 //kursywa
             }


             if (dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count - 2)
             {
                 nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();

                 liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[2].Value)).Days;

                 if (liczba_dni < 0)
                 {
                     data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                     data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                     int liczbadni2 = System.Math.Abs(liczba_dni);
                     data_badania_nastepny_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                     //ustawic kursywy pogrubiona w labelce 
                 }
                 if (liczba_dni == 0)
                 {
                     data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                     data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                     data_badania_nastepny_pacjent.Text = ("Dzisiaj");
                     //na czerwono dzisiaj
                 }
                 if (liczba_dni > 0)
                 {
                     data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                     data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                     data_badania_nastepny_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                     //kursywa
                 }



             }
             else
             {
                 nastepny_pacjent.Text = ("Brak");
                 data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                 data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                 data_badania_nastepny_pacjent.Text = ("Brak");
             }*/
        }

        private void zapisz_do_pliku_Click(object sender, EventArgs e)
        {
            string kolejka_csv = string.Empty;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        kolejka_csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ';';
                    }
                }
                kolejka_csv += "\r\n";
            }
            string folderPath = "c:\\temp\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText(folderPath + "kolejka.txt", kolejka_csv);
            MessageBox.Show("Zapisano do pliku");
        }

        private void Godzina_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
               /* if (dataGridView1.CurrentCell != null)
                {
                    if (dataGridView1.CurrentCell.RowIndex >= 1)
                    {
                        poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();


                        liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                        if (liczba_dni < 0)
                        {
                            data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                            data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                            int liczbadni2 = System.Math.Abs(liczba_dni);
                            data_badania_poprzedni_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                            //ustawic kursywy pogrubiona w labelce 
                        }
                        if (liczba_dni == 0)
                        {
                            data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                            data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                            data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                            //na czerwono dzisiaj
                        }
                        if (liczba_dni > 0)
                        {
                            data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                            data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                            data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                            //kursywa
                        }

                        //data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

                    }
                    else
                    {
                        poprzedni_pacjent.Text = ("Brak");
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                        data_badania_poprzedni_pacjent.Text = ("Brak");
                    }

                    aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_wybrany_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_wybrany_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_wybrany_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }


                    if (dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count - 2)
                    {
                        nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();

                        liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[2].Value)).Days;

                        if (liczba_dni < 0)
                        {
                            data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                            data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                            int liczbadni2 = System.Math.Abs(liczba_dni);
                            data_badania_nastepny_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                            //ustawic kursywy pogrubiona w labelce 
                        }
                        if (liczba_dni == 0)
                        {
                            data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                            data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                            data_badania_nastepny_pacjent.Text = ("Dzisiaj");
                            //na czerwono dzisiaj
                        }
                        if (liczba_dni > 0)
                        {
                            data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                            data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                            data_badania_nastepny_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                            //kursywa
                        }



                    }
                    else
                    {
                        nastepny_pacjent.Text = ("Brak");
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                        data_badania_nastepny_pacjent.Text = ("Brak");
                    }
                }*/
            }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 1)
                {
                    poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();


                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }

                    //data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

                }
                else
                {
                    poprzedni_pacjent.Text = ("Brak");
                    data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_poprzedni_pacjent.Text = ("Brak");
                }

                aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value)).Days;

                if (liczba_dni < 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    int liczbadni2 = System.Math.Abs(liczba_dni);
                    data_badania_wybrany_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                    //ustawic kursywy pogrubiona w labelce 
                }
                if (liczba_dni == 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    data_badania_wybrany_pacjent.Text = ("Dzisiaj");
                    //na czerwono dzisiaj
                }
                if (liczba_dni > 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                    data_badania_wybrany_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                    //kursywa
                }


                if (dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count - 2)
                {
                    nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();

                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_nastepny_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_nastepny_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_nastepny_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }



                }
                else
                {
                    nastepny_pacjent.Text = ("Brak");
                    data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_nastepny_pacjent.Text = ("Brak");
                }
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 1)
                {
                    poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();


                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }

                    //data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

                }
                else
                {
                    poprzedni_pacjent.Text = ("Brak");
                    data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_poprzedni_pacjent.Text = ("Brak");
                }

                aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value)).Days;

                if (liczba_dni < 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    int liczbadni2 = System.Math.Abs(liczba_dni);
                    data_badania_wybrany_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                    //ustawic kursywy pogrubiona w labelce 
                }
                if (liczba_dni == 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    data_badania_wybrany_pacjent.Text = ("Dzisiaj");
                    //na czerwono dzisiaj
                }
                if (liczba_dni > 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                    data_badania_wybrany_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                    //kursywa
                }


                if (dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count - 2)
                {
                    nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();

                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_nastepny_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_nastepny_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_nastepny_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }



                }
                else
                {
                    nastepny_pacjent.Text = ("Brak");
                    data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_nastepny_pacjent.Text = ("Brak");
                }
            }*/
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 1)
                {
                    poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();


                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }

                    //data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

                }
                else
                {
                    poprzedni_pacjent.Text = ("Brak");
                    data_badania_poprzedni_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_poprzedni_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_poprzedni_pacjent.Text = ("Brak");
                }

                aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value)).Days;

                if (liczba_dni < 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    int liczbadni2 = System.Math.Abs(liczba_dni);
                    data_badania_wybrany_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                    //ustawic kursywy pogrubiona w labelce 
                }
                if (liczba_dni == 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                    data_badania_wybrany_pacjent.Text = ("Dzisiaj");
                    //na czerwono dzisiaj
                }
                if (liczba_dni > 0)
                {
                    data_badania_wybrany_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_wybrany_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                    data_badania_wybrany_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                    //kursywa
                }


                if (dataGridView1.CurrentCell.RowIndex <= dataGridView1.Rows.Count - 2)
                {
                    nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();

                    liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[2].Value)).Days;

                    if (liczba_dni < 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        int liczbadni2 = System.Math.Abs(liczba_dni);
                        data_badania_nastepny_pacjent.Text = ("badanie odbedzie sie za " + liczbadni2.ToString() + "dni");
                        //ustawic kursywy pogrubiona w labelce 
                    }
                    if (liczba_dni == 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(255, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                        data_badania_nastepny_pacjent.Text = ("Dzisiaj");
                        //na czerwono dzisiaj
                    }
                    if (liczba_dni > 0)
                    {
                        data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                        data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Italic);
                        data_badania_nastepny_pacjent.Text = ("badanie odbylo sie " + liczba_dni.ToString() + "dni temu");
                        //kursywa
                    }



                }
                else
                {
                    nastepny_pacjent.Text = ("Brak");
                    data_badania_nastepny_pacjent.ForeColor = Color.FromArgb(0, 0, 0);
                    data_badania_nastepny_pacjent.Font = new Font("Arial", 10, FontStyle.Regular);
                    data_badania_nastepny_pacjent.Text = ("Brak");
                }
            }
        }
    }
           
}
