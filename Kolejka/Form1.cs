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
        public Form1()
        {
            InitializeComponent();

            




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
            Queue kolejkapacjent = new Queue();
            kolejkapacjent.Enqueue(podaj_imie);
            //kolejkapacjent.Count;
        }
    }
}
