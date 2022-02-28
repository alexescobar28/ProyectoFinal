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
            public string butacas;
        }
        static public InformacionCompra compra;
        
        int contadorBoletos;
        
        public Boleteria()
        {
            InitializeComponent();
            contadorBoletos = 0;
        }
        void contarTipo()
        {
            if (subtitulada.Checked)
            {
                compra.tipo = "Subtitulada";
            }
            if (traducida.Checked)
            {
                compra.tipo = "Subtitulada";
            }

         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            contarTipo();
            asignarAsientos();

            compra.cantidad = contadorBoletos;
            compra.subtotalBoletos = compra.cantidad * 5;
            compra.fecha =dtFecha.Text;
            Datos.pelicula = compra.pelicula+compra.tipo;
            Datos.butacas = compra.butacas;
            Datos.fecha =compra.fecha;

            Comida comida = new Comida();
            this.Hide();
            comida.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPeliculas.SelectedIndex == 0)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Avengers;
                compra.pelicula = cmbPeliculas.Text;
            }
            if (cmbPeliculas.SelectedIndex == 1)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.John_Wick;
                compra.pelicula = cmbPeliculas.Text;
            }
            if (cmbPeliculas.SelectedIndex == 2)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Spider_man;
                compra.pelicula = cmbPeliculas.Text;
            }
            if (cmbPeliculas.SelectedIndex == 3)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Insidious;
                compra.pelicula = cmbPeliculas.Text;
            }
            if (cmbPeliculas.SelectedIndex == 4)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Son_como_niños;
                compra.pelicula = cmbPeliculas.Text;
            }


        }



        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void subtitulada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            validarFecha();
        }
        void validarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (dtFecha.Value.Date < hoy)
            {
                MessageBox.Show("Fecha invalida no puede seleccionar una fecha pasada", "Error de ingreso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DateTime fecha=dtFecha.Value;
                compra.fecha = fecha.ToString();

            }
        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void asignarAsientos()
        {
            if (a1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A1";

            }
            if (a2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A2";
            }
            if (a3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A3";
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B1";
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B2";
            }
            if (b3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B3";
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B4";
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B5";
            }
            if (c3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B6";
            }
        }
    }
}
