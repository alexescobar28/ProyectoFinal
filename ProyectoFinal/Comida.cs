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
    public partial class Comida : Form
    {
        private const bool V = true;

        public struct Alimentos
        {
            public String snack;
            public String bebida;
            public String combos;
            int contador;
        }
        public Comida()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCombo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {




        }

        private ComboBox GetCmbSnack()
        {
            return cmbSnack;
        }

        private void cmbSnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSnack.SelectedIndex == -1)
            {
                pcbSnack1.Visible = false;
                pcbSnack2.Visible = false;
                pcbSnack3.Visible = false;
                pcbSnack4.Visible = false;
            }
            if (cmbSnack.SelectedIndex == 0)
            {
                pcbSnack1.Visible = true;
            }
            if (cmbSnack.SelectedIndex == 1)
            {
                pcbSnack2.Visible = true;
            }
            if (cmbSnack.SelectedIndex == 2)
            {
                pcbSnack3.Visible = true;
            }
            if (cmbSnack.SelectedIndex == 3)
            {
                pcbSnack4.Visible = true;
            }

        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBebidas.SelectedIndex == -1)
            {
                pcbBebida1.Visible = false;
                pcbBebida2.Visible = false;
                pcbBebida3.Visible = false;
                pcbBebida4.Visible = false;
            }
            if (cmbBebidas.SelectedIndex == 0)
            {
                pcbBebida1.Visible = true;
            }
            if (cmbBebidas.SelectedIndex == 1)
            {
                pcbBebida2.Visible = true;
            }
            if (cmbBebidas.SelectedIndex == 2)
            {
                pcbBebida3.Visible = true;
            }
            if (cmbBebidas.SelectedIndex == 3)
            {
                pcbBebida4.Visible = true;
            }
        }
    }
}
