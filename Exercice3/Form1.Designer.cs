namespace Exercice3
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
            this.textOperand1 = new System.Windows.Forms.TextBox();
            this.textOperand2 = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.labelOperand2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textOperand1
            // 
            this.textOperand1.Location = new System.Drawing.Point(319, 99);
            this.textOperand1.Name = "textOperand1";
            this.textOperand1.Size = new System.Drawing.Size(100, 20);
            this.textOperand1.TabIndex = 0;
            // 
            // textOperand2
            // 
            this.textOperand2.Location = new System.Drawing.Point(319, 176);
            this.textOperand2.Name = "textOperand2";
            this.textOperand2.Size = new System.Drawing.Size(100, 20);
            this.textOperand2.TabIndex = 1;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(319, 274);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(469, 274);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(217, 274);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Location = new System.Drawing.Point(250, 102);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(63, 13);
            this.labelOperand1.TabIndex = 5;
            this.labelOperand1.Text = "Operand 1 :";
            // 
            // labelOperand2
            // 
            this.labelOperand2.AutoSize = true;
            this.labelOperand2.Location = new System.Drawing.Point(250, 179);
            this.labelOperand2.Name = "labelOperand2";
            this.labelOperand2.Size = new System.Drawing.Size(63, 13);
            this.labelOperand2.TabIndex = 6;
            this.labelOperand2.Text = "Operand 2 :";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(349, 249);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelOperand2);
            this.Controls.Add(this.labelOperand1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textOperand2);
            this.Controls.Add(this.textOperand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOperand1;
        private System.Windows.Forms.TextBox textOperand2;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.Label labelOperand2;
        private System.Windows.Forms.Label labelResult;
    }
}

