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
            public string pelicula;
            public string fecha;
            public string hora;
            public string tipo;
            public string butacas;
        }
        static public InformacionCompra compra;
        
        int contadorBoletos;
        const int VALOR_ENTRADA = 5;
        public Boleteria()
        {
            InitializeComponent();
            compra.pelicula = "spiderman";//por defecto 
            compra.hora = "11:00"; //por defecto
            cmbPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;
            contadorBoletos = 0;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            contarTipo();
            asignarAsientos();
            if (compra.butacas==null || compra.tipo == null)
            {
                MessageBox.Show("Preocure llenar todos los campos ", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                compra.cantidad = contadorBoletos;
                compra.subtotalBoletos = compra.cantidad * VALOR_ENTRADA;
                compra.fecha = dtFecha.Text;//por defecto el dia hoy 
                Datos.pelicula = compra.pelicula + '-' + compra.tipo;//asigno variable global concateno pelicula y el tipo 
                Datos.butacas = compra.butacas;//variable global
                Datos.fecha = compra.fecha;
                Datos.hora = compra.hora;
                Datos.contadorAsientos = contadorBoletos;
                Datos.subtotalEntradas = compra.subtotalBoletos;
                Comida comida = new Comida();
                this.Hide();
                comida.Show();
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPeliculas.SelectedIndex == 0)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Avengers;
                compra.pelicula = cmbPeliculas.Text;
                lblSinopsis.Text = "Tras los sucesos de “Vengadores: Infinity War”, los superhéroes que sobrevivieron a Thanos se reunen para poner en práctica un plan definitivo que podría acabar con el villano definitivamente. No saben si funcionará, pero es su única oportunidad de intentarlo. Cuarta entrega de la saga “Vengadores”";
                
            }
            if (cmbPeliculas.SelectedIndex == 1)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.John_Wick;
                compra.pelicula = cmbPeliculas.Text;
                lblSinopsis.Text = "En Nueva York, John Wick, un asesino a sueldo retirado, vuelve otra vez a la acción para vengarse de los gángsters que le quitaron todo.";
            }
            if (cmbPeliculas.SelectedIndex == 2)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Spider_man;
                compra.pelicula = cmbPeliculas.Text;
                lblSinopsis.Text = "Después de que Mysterio desvelara la identidad de Spider-Man a todo el mundo en Lejos de casa, Peter Parker (Tom Holland), desesperado por volver a la normalidad y recuperar su anterior vida, pide ayuda a Doctor Strange para enmendar tal acción. El Hechicero Supremo de Marvel accede a ayudar al joven Hombre Araña, sin embargo, algo sale mal y el multiverso se convierte en la mayor amenaza hasta el momento.";
            }
            if (cmbPeliculas.SelectedIndex == 3)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Insidious;
                compra.pelicula = cmbPeliculas.Text;
                lblSinopsis.Text = "Josh, su esposa Reani y sus tres hijos se mudan a una nueva casa cuando uno de los hijos cae en un estado de coma sin explicación. Poco tiempo después, una sucesión de fenómenos paranormales comienza a producirse. Un medium les dice que el alma de su hijo se encuentra en algún lugar entre la vida y la muerte en la dimensió...";
            }
            if (cmbPeliculas.SelectedIndex == 4)
            {
                pbPeliculas.Image = ProyectoFinal.Properties.Resources.Son_como_niños;
                compra.pelicula = cmbPeliculas.Text;
                lblSinopsis.Text = "La muerte del entrenador de baloncesto de su infancia lleva a una reunión de viejos amigos (Adam Sandler, Kevin James, Chris Rock), que se reúnen en el lugar de la celebración de un campeonato años antes. Continuando donde lo dejaron, los amigos, con esposas e hijos a cuestas, descubren por qué la edad no es necesariamente igual a la madurez. ";
            }


        }



        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            validarFecha();
        }
        public void validarFecha()
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
        void asignarAsientos()
        {
            if (a1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A1,";

            }
            if (a2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A2,";
            }
            if (a3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "A3,";
            }
            if (b1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B1,";
            }
            if (b2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B2,";
            }
            if (b3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "B3,";
            }
            if (c1.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "C1,";
            }
            if (c2.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "C2,";
            }
            if (c3.Checked == true)
            {
                contadorBoletos++;
                compra.butacas += "C3,";
            }
        }
        public void contarTipo()
        {
            if (subtitulada.Checked)
            {
                compra.tipo = "Subtitulada";
            }
            if (traducida.Checked)
            {
                compra.tipo = "Traducida";
            }


        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbPeliculas.SelectedIndex == 0)
            {
                compra.hora = "11:00";

            }
            if (cmbPeliculas.SelectedIndex == 1)
            {
                compra.hora = "13:00";

            }
            if (cmbPeliculas.SelectedIndex == 2)
            {
                compra.hora = "15:00";

            }
            if (cmbPeliculas.SelectedIndex == 0)
            {
                compra.hora = "17:00";

            }
            if (cmbPeliculas.SelectedIndex == 0)
            {
                compra.hora = "19:00";

            }
            if (cmbPeliculas.SelectedIndex == 0)
            {
                compra.hora = "21:00";

            }
            if (cmbPeliculas.SelectedIndex == 0)
            {
                compra.hora = "23:00";

            }



        }
    }
}
