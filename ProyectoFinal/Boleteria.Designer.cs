﻿namespace ProyectoFinal
{
    partial class frmBoleteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoleteria));
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.CheckBox();
            this.a2 = new System.Windows.Forms.CheckBox();
            this.a3 = new System.Windows.Forms.CheckBox();
            this.b1 = new System.Windows.Forms.CheckBox();
            this.b2 = new System.Windows.Forms.CheckBox();
            this.b3 = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdSubtitulada = new System.Windows.Forms.RadioButton();
            this.rdTraducida = new System.Windows.Forms.RadioButton();
            this.pcbPeliculas = new System.Windows.Forms.PictureBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Items.AddRange(new object[] {
            "Avengers",
            "Jhon Wick",
            "Spiderman",
            "Insidious",
            "Son como niños"});
            this.cmbPeliculas.Location = new System.Drawing.Point(117, 43);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(121, 21);
            this.cmbPeliculas.TabIndex = 0;
            this.cmbPeliculas.Text = "Spiderman";
            this.cmbPeliculas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Películas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asientos ";
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(399, 263);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(42, 20);
            this.a1.TabIndex = 5;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(520, 263);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(42, 20);
            this.a2.TabIndex = 6;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(641, 262);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(42, 20);
            this.a3.TabIndex = 7;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(399, 300);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(42, 20);
            this.b1.TabIndex = 8;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(520, 300);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(42, 20);
            this.b2.TabIndex = 9;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(641, 300);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(42, 20);
            this.b3.TabIndex = 10;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(399, 334);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(42, 20);
            this.c1.TabIndex = 11;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(520, 334);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(42, 20);
            this.c2.TabIndex = 12;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(641, 334);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(42, 20);
            this.c3.TabIndex = 13;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(492, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Comida ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy-MM-dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(535, 84);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 16;
            this.dtFecha.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sinopsis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Costo cada entrada: $5";
            // 
            // rdSubtitulada
            // 
            this.rdSubtitulada.AutoSize = true;
            this.rdSubtitulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSubtitulada.Location = new System.Drawing.Point(263, 84);
            this.rdSubtitulada.Margin = new System.Windows.Forms.Padding(2);
            this.rdSubtitulada.Name = "rdSubtitulada";
            this.rdSubtitulada.Size = new System.Drawing.Size(92, 20);
            this.rdSubtitulada.TabIndex = 25;
            this.rdSubtitulada.TabStop = true;
            this.rdSubtitulada.Text = "Subtitulada";
            this.rdSubtitulada.UseVisualStyleBackColor = true;
            // 
            // rdTraducida
            // 
            this.rdTraducida.AutoSize = true;
            this.rdTraducida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTraducida.Location = new System.Drawing.Point(263, 106);
            this.rdTraducida.Margin = new System.Windows.Forms.Padding(2);
            this.rdTraducida.Name = "rdTraducida";
            this.rdTraducida.Size = new System.Drawing.Size(87, 20);
            this.rdTraducida.TabIndex = 26;
            this.rdTraducida.TabStop = true;
            this.rdTraducida.Text = "Traducida";
            this.rdTraducida.UseVisualStyleBackColor = true;
            // 
            // pcbPeliculas
            // 
            this.pcbPeliculas.Image = global::ProyectoFinal.Properties.Resources.Spider_man;
            this.pcbPeliculas.Location = new System.Drawing.Point(31, 75);
            this.pcbPeliculas.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPeliculas.Name = "pcbPeliculas";
            this.pcbPeliculas.Size = new System.Drawing.Size(197, 280);
            this.pcbPeliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPeliculas.TabIndex = 18;
            this.pcbPeliculas.TabStop = false;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(261, 184);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(474, 61);
            this.lblSinopsis.TabIndex = 27;
            this.lblSinopsis.Text = resources.GetString("lblSinopsis.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hora:";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00",
            "21:00",
            "23:00"});
            this.cmbHora.Location = new System.Drawing.Point(535, 121);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 29;
            this.cmbHora.Text = "11:00";
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "BOLETERIA";
            // 
            // frmBoleteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.rdTraducida);
            this.Controls.Add(this.rdSubtitulada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbPeliculas);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBoleteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleteria ";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox a1;
        private System.Windows.Forms.CheckBox a2;
        private System.Windows.Forms.CheckBox a3;
        private System.Windows.Forms.CheckBox b1;
        private System.Windows.Forms.CheckBox b2;
        private System.Windows.Forms.CheckBox b3;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.PictureBox pcbPeliculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdSubtitulada;
        private System.Windows.Forms.RadioButton rdTraducida;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label6;
    }
}