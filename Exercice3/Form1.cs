using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int total;

            try
            {
                int var1 = Int32.Parse(textOperand1.Text);
                int var2 = Int32.Parse(textOperand2.Text);

                total = var1 + var2;

                textTotal.Text = total.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid values");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textOperand1.Text = "";
            textOperand2.Text = "";
            textTotal.Text = "";
        }
    }
}
