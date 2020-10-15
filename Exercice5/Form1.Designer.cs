namespace Exercice5
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
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxCat = new System.Windows.Forms.CheckBox();
            this.checkBoxDog = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.AutoSize = true;
            this.checkBoxMouse.Location = new System.Drawing.Point(106, 82);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMouse.TabIndex = 0;
            this.checkBoxMouse.Text = "Mouse";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            this.checkBoxMouse.CheckedChanged += new System.EventHandler(this.checkBoxMouse_CheckedChanged);
            // 
            // checkBoxCat
            // 
            this.checkBoxCat.AutoSize = true;
            this.checkBoxCat.Location = new System.Drawing.Point(106, 117);
            this.checkBoxCat.Name = "checkBoxCat";
            this.checkBoxCat.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCat.TabIndex = 1;
            this.checkBoxCat.Text = "Cat";
            this.checkBoxCat.UseVisualStyleBackColor = true;
            this.checkBoxCat.CheckedChanged += new System.EventHandler(this.checkBoxCat_CheckedChanged);
            // 
            // checkBoxDog
            // 
            this.checkBoxDog.AutoSize = true;
            this.checkBoxDog.Location = new System.Drawing.Point(106, 153);
            this.checkBoxDog.Name = "checkBoxDog";
            this.checkBoxDog.Size = new System.Drawing.Size(46, 17);
            this.checkBoxDog.TabIndex = 2;
            this.checkBoxDog.Text = "Dog";
            this.checkBoxDog.UseVisualStyleBackColor = true;
            this.checkBoxDog.CheckedChanged += new System.EventHandler(this.checkBoxDog_CheckedChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(106, 281);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(484, 20);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.Text = "Choosen animals: ";
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(106, 229);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.checkBoxDog);
            this.Controls.Add(this.checkBoxCat);
            this.Controls.Add(this.checkBoxMouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMouse;
        private System.Windows.Forms.CheckBox checkBoxCat;
        private System.Windows.Forms.CheckBox checkBoxDog;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonOk;
    }
}

