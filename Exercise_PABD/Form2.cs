﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_PABD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
