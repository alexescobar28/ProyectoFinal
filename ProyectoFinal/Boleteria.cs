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
        public Boleteria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            this.Hide();
            comida.Show();
        }
    }
}
