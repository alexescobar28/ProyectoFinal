using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Boleteria : Form
    {

        public struct InformacionCompra
        {
            public int cantidad;
            public double subtotalBoletos;
            public String pelicula;
            public String fecha;
            public String tipo;
        }
        static public InformacionCompra compra;
        
        int contadorBoletos;
        
        public Boleteria()
        {
            InitializeComponent();
            contadorBoletos = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (subtitulada.Checked)
            {
                compra.tipo = "Subtitulada";
            }
            if (traducida.Checked)
            {
                compra.tipo = "Subtitulada";
            }
         
            if (a1.Checked==true)
            {
                contadorBoletos++;
            }
            if (a2.Checked == true)
            {
                contadorBoletos++;
            }
            if (a3.Checked == true)
            {
                contadorBoletos++;
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
            }
            if (b3.Checked == true)
            {
                contadorBoletos++;
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
            }
            if (c3.Checked == true)
            {
                contadorBoletos++;
            }

            compra.cantidad = contadorBoletos;
            compra.subtotalBoletos = compra.cantidad * 5;
            compra.fecha =DateTimePicker.Text;
            
            Comida comida = new Comida();
            this.Hide();
            comida.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (comboBox1.SelectedIndex == -1)
            {
                pictureBox1 = null;
                pictureBox2 = null;
                pelicula=null;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Avengers;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Avengers;
                pelicula="Avengers";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.John_Wick;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_John_Wick;
                pelicula="John Wick";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Spider-man;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Spider-man;
                pelicula="Spider-man";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Insidious;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Insidious;
                pelicula="Insidious";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Son_Como_niños;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Son_como_niños;
                pelicula="Son como niños"
            }
            */

        }

        

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (a1.Checked == true)
            {
                contadorBoletos++;
            }
            if (a2.Checked == true)
            {
                contadorBoletos++;
            }
            if (a3.Checked == true)
            {
                contadorBoletos++;
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
            }
            if (b3.Checked == true)
            {
                contadorBoletos++;
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
            }
            if (c3.Checked == true)
            {
                contadorBoletos++;
            }

            compra.cantidad = contadorBoletos;
            compra.subtotalBoletos = compra.cantidad * 5;
            compra.fecha = DateTimePicker.Text;

            Facturas f2 = new Facturas();
            f2.Show();
            this.Hide();
        }
    }
}
