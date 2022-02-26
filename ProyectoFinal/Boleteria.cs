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
        int cantidad;
        double subtotalBoletos;
        String fecha;
        public Boleteria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(txtnumeroBoletos);
            subtotalBoletos = cantidad * 5;

            fecha=DateTimePicker.Text;
            MessageBox.Show(fecha);
         /*   Comida comida = new Comida();
            this.Hide();
            comida.Show();
   */     }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

            }
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Avengers;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Avengers;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.John_Wick;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_John_Wick;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Spider-man;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Spider-man;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Insidious;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Insidious;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1 = ProyectoFinal.Properties.Resources.Son_Como_niños;
                pictureBox2 = ProyectoFinal.Properties.Resources.Sinopsis_Son_como_niños;
            }
        }

     

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
