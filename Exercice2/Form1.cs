﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEx2.Checked == true)
            {
                MessageBox.Show("Check Box checked");
            }

            if (checkEx2.Checked == false)
            {
                MessageBox.Show("Check Box unchecked");
            }
        }
    }
}
