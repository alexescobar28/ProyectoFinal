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
            if (persona.nombre == "")
            {
                MessageBox.Show("error llene todos los datos por favor ","Error ingreso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Datos.CI = persona.cedula;
                Datos.nombre = persona.nombre;
                Datos.apellido = persona.apellido;
                Boleteria boleteria = new Boleteria();
                this.Hide();
                boleteria.Show();
            }
            
            
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar<=47)||(e.KeyChar>=58 && e.KeyChar <= 255)){
                e.Handled=true; 
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)|| (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
