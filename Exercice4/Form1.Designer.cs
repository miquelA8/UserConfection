﻿namespace Exercice4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textOperand2 = new System.Windows.Forms.TextBox();
            this.textOperand1 = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(337, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(337, 129);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstract.TabIndex = 1;
            this.buttonSubstract.Text = "Substract";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(232, 223);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(493, 220);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textOperand2
            // 
            this.textOperand2.Location = new System.Drawing.Point(162, 132);
            this.textOperand2.Name = "textOperand2";
            this.textOperand2.Size = new System.Drawing.Size(100, 20);
            this.textOperand2.TabIndex = 4;
            // 
            // textOperand1
            // 
            this.textOperand1.Location = new System.Drawing.Point(162, 74);
            this.textOperand1.Name = "textOperand1";
            this.textOperand1.Size = new System.Drawing.Size(100, 20);
            this.textOperand1.TabIndex = 5;
            this.textOperand1.TextChanged += new System.EventHandler(this.textOperand1_TextChanged);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(493, 106);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 6;
            this.textTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textSymbol
            // 
            this.textSymbol.Location = new System.Drawing.Point(356, 223);
            this.textSymbol.Name = "textSymbol";
            this.textSymbol.Size = new System.Drawing.Size(32, 20);
            this.textSymbol.TabIndex = 7;
            this.textSymbol.TextChanged += new System.EventHandler(this.textSymbol_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Operation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "What you want do?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSymbol);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textOperand1);
            this.Controls.Add(this.textOperand2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textOperand2;
        private System.Windows.Forms.TextBox textOperand1;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

