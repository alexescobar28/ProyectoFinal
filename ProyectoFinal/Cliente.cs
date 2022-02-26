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
    public partial class Cliente : Form
    {
        public struct InformacionCliente
        {
            public String nombre;
            public String apellido;
            public String cedula;

        }
        static public InformacionCliente persona;
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            persona.nombre = txtNombre.Text;
            persona.apellido = txtApellido.Text;
            persona.cedula = txtCedula.Text;

                Boleteria boleteria = new Boleteria();
                this.Hide();
                boleteria.Show();
            //  MessageBox.Show("hola mundo "+persona.apellido+" "+persona.nombre+" "+persona.cedula);


        }
    }
}
