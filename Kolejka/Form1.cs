using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            label1.Text = dataGridView1.Rows.Count.ToString();
            
        }

        private void podaj_date_text_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_do_kolejki_Click(object sender, EventArgs e)
        {
            nazwa = podaj_imie.Text;
            nazwa_badania = wprowadz_nazwe_badan.Text;
            dataa = wybierz_date.Value.Date;
            //kolejkapacjent.Enqueue(podaj_imie.ToString());

            //aktualny_pacjent.Text = kolejkapacjent.Peek();


            //foreach (Object obj in kolejkapacjent)
           // { 
            //  aktualny_pacjent.Text = (obj.ToString());
           // }

           // int i = kolejkapacjent.Count;
            

           // label1.Text = i.ToString();


            dataGridView1.Rows.Add(nazwa,nazwa_badania,dataa );


        }


        private void usun_z_kolejki_Click(object sender, EventArgs e)
        {
            //kolejkapacjent.Dequeue();

            if (this.dataGridView1.SelectedRows.Count > 0 &&
            this.dataGridView1.SelectedRows[0].Index !=
            this.dataGridView1.Rows.Count - 1)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
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

            kolejkapacjent.Dequeue();
            foreach (Object obj in kolejkapacjent)
            {
                aktualny_pacjent.Text = (obj.ToString());
            }

            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 1 )
            {
                poprzedni_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString();
                

                liczba_dni = (DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value)).Days;

                if (liczba_dni < 0)
                {
                    //ustawic kursywy pogrubiona w labelce 
                }else if(liczba_dni == 0)
                {
                    data_badania_poprzedni_pacjent.Text = ("Dzisiaj");
                    //na czerwono dzisiaj
                }
                else(liczba_dni > 0){
                   // data_badania_poprzedni_pacjent.Text = ("badanie odbylo sie ", liczba_dni.ToString(), "dni temu");
                    //kursywa
                }

                data_badania_poprzedni_pacjent.Text = liczba_dni.ToString();

            }
            else
            {
                poprzedni_pacjent.Text = ("Brak");
            }
            
            aktualny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            
            
            if (dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count - 2)
            {
                nastepny_pacjent.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0].Value.ToString();
            }
            else
            {
                nastepny_pacjent.Text = ("Brak");
            }
        }
    }
}
