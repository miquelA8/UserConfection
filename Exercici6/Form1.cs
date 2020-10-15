using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fill = "The choosen colour is: ";

            textBox.Text = fill + colorBox.SelectedItem;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
