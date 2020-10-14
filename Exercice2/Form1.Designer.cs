namespace Exercice2
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
            this.checkEx2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkEx2
            // 
            this.checkEx2.AutoSize = true;
            this.checkEx2.Location = new System.Drawing.Point(343, 174);
            this.checkEx2.Name = "checkEx2";
            this.checkEx2.Size = new System.Drawing.Size(78, 17);
            this.checkEx2.TabIndex = 0;
            this.checkEx2.Text = "Check Box";
            this.checkEx2.UseVisualStyleBackColor = true;
            this.checkEx2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkEx2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkEx2;
    }
}

