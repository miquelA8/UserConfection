using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxMouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void checkerMouse()
        {
            if (checkBoxMouse.Checked == true)
            {
                textBoxResult.Text = textBoxResult.Text + "Mouse ";
            }
        }
        private void checkerCat()
        {
            if (checkBoxCat.Checked == true)
            {
                textBoxResult.Text = textBoxResult.Text + "Cat ";
            }
        }

        private void checkerDog()
        {
            if (checkBoxDog.Checked == true)
            {
                textBoxResult.Text = textBoxResult.Text + "Dog  ";
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "Choosen animals: ";
            checkerMouse();
            checkerCat();
            checkerDog();
        }

        private void checkBoxCat_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxDog_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
