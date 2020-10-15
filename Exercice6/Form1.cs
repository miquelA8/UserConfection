using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String fill = "Choosen Colour ";
            if (radioButtonBlue.Checked)
            textColour.Text = fill + "Blue";
            if (radioButtonRed.Checked)
            textColour.Text = fill + "Red";
            if (radioButtonWhite.Checked)
            textColour.Text = fill + "White";
        }
    }
}
