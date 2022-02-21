namespace ProyectoFinal
{
    partial class Comida
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSnack = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.chkCombo1 = new System.Windows.Forms.CheckBox();
            this.chkCombo2 = new System.Windows.Forms.CheckBox();
            this.chkCombo3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Snacks ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bebidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Combos";
            // 
            // cmbSnack
            // 
            this.cmbSnack.FormattingEnabled = true;
            this.cmbSnack.Location = new System.Drawing.Point(147, 58);
            this.cmbSnack.Name = "cmbSnack";
            this.cmbSnack.Size = new System.Drawing.Size(121, 21);
            this.cmbSnack.TabIndex = 6;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(147, 107);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 21);
            this.cmbBebidas.TabIndex = 7;
            // 
            // chkCombo1
            // 
            this.chkCombo1.AutoSize = true;
            this.chkCombo1.Location = new System.Drawing.Point(157, 191);
            this.chkCombo1.Name = "chkCombo1";
            this.chkCombo1.Size = new System.Drawing.Size(80, 17);
            this.chkCombo1.TabIndex = 8;
            this.chkCombo1.Text = "checkBox1";
            this.chkCombo1.UseVisualStyleBackColor = true;
            // 
            // chkCombo2
            // 
            this.chkCombo2.AutoSize = true;
            this.chkCombo2.Location = new System.Drawing.Point(157, 235);
            this.chkCombo2.Name = "chkCombo2";
            this.chkCombo2.Size = new System.Drawing.Size(80, 17);
            this.chkCombo2.TabIndex = 9;
            this.chkCombo2.Text = "checkBox2";
            this.chkCombo2.UseVisualStyleBackColor = true;
            // 
            // chkCombo3
            // 
            this.chkCombo3.AutoSize = true;
            this.chkCombo3.Location = new System.Drawing.Point(157, 277);
            this.chkCombo3.Name = "chkCombo3";
            this.chkCombo3.Size = new System.Drawing.Size(80, 17);
            this.chkCombo3.TabIndex = 10;
            this.chkCombo3.Text = "checkBox3";
            this.chkCombo3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkCombo3);
            this.Controls.Add(this.chkCombo2);
            this.Controls.Add(this.chkCombo1);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.cmbSnack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Comida";
            this.Text = "Comida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSnack;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.CheckBox chkCombo1;
        private System.Windows.Forms.CheckBox chkCombo2;
        private System.Windows.Forms.CheckBox chkCombo3;
        private System.Windows.Forms.Button button1;
    }
}