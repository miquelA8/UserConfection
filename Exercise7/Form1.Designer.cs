namespace Exercise7
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
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.textSolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Cian",
            "Yellow"});
            this.colorBox.Location = new System.Drawing.Point(325, 92);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 21);
            this.colorBox.TabIndex = 0;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textSolution
            // 
            this.textSolution.Location = new System.Drawing.Point(157, 312);
            this.textSolution.Name = "textSolution";
            this.textSolution.Size = new System.Drawing.Size(476, 20);
            this.textSolution.TabIndex = 1;
            this.textSolution.Text = "The colour choosen is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSolution);
            this.Controls.Add(this.colorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.TextBox textSolution;
    }
}

