﻿using System;
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


            
            
            data.Text = DateTime.Now.ToString("d/M/yyyy");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
