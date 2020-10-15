using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4
{
    public partial class Form1 : Form
    {
        int var1;
        int var2;
        int total;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOperand1_TextChanged(object sender, EventArgs e)
        {

        }
        private  void addStonks()
        {
            total = var1 + var2;
            textTotal.Text = total.ToString();
        }

        private void substractStonks()
        {
            total = var1 - var2;
            textTotal.Text = total.ToString();
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                var1 = Int32.Parse(textOperand1.Text);
                var2 = Int32.Parse(textOperand2.Text);

                if (listSymbol.Text == "+")
                {
                    addStonks();
                }
                else if (listSymbol.Text == "-")
                    {
                    substractStonks();
                }
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

        private void textSymbol_TextChanged(object sender, EventArgs e)
        {
            if (listSymbol.Text == "+")
            {
                textSymbol.Text = "+";
            }
            else if (listSymbol.Text == "-")
            {
                textSymbol.Text = "-";
            }

        }
/*
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textSymbol.Text = "+";
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            textSymbol.Text = "-";
        }
*/
        private void listSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (listSymbol.SelectedIndex == 0)
            {
                textSymbol.Text = "+";
            }
          else if (listSymbol.SelectedIndex == 1)
            {
                textSymbol.Text = "-";
            }
                
        }
    }
}
