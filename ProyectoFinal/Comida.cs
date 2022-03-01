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
            public string snack;
            public string bebida;
            public String combos;
            public double subTotal;
        }
        static public Alimentos alimentos;

        
        public Comida()
        {
            
            InitializeComponent();
            alimentos.snack = "Ninguno";
            alimentos.bebida = "Ninguno";
            cmbSnack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBebidas.DropDownStyle = ComboBoxStyle.DropDownList;
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCombo2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            colocarPrecios();
            Datos.comida=alimentos.combos+"\nSnack:"+alimentos.snack + "\nBebida:"+alimentos.bebida;
            Datos.subtotalComidas = alimentos.subTotal;
            Facturas facturas = new Facturas();
            this.Hide();
            facturas.Show();
           
        }

        private ComboBox GetCmbSnack()
        {
            return cmbSnack;
        }

        private void cmbSnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSnack.SelectedIndex == -1)
            {
                alimentos.snack = "Ninguno";
            }
            if (cmbSnack.SelectedIndex == 0)
            {
                pcbSnack1.Visible = true;
                pcbSnack2.Visible = false;
                pcbSnack3.Visible = false;
                pcbSnack4.Visible = false;
                alimentos.snack = "Manicho";
                alimentos.subTotal = 1;
            }
            if (cmbSnack.SelectedIndex == 1)
            {
                pcbSnack2.Visible = true;
                pcbSnack1.Visible = false;
                pcbSnack3.Visible = false;
                pcbSnack4.Visible = false;
                alimentos.snack = "Nachos con queso";
                alimentos.subTotal = 2.50;
            }
            if (cmbSnack.SelectedIndex == 2)
            {
                pcbSnack3.Visible = true;
                pcbSnack1.Visible = false;
                pcbSnack2.Visible = false;
                pcbSnack4.Visible = false;
                alimentos.snack = "Tango";
                alimentos.subTotal = 0.50;
            }
            if (cmbSnack.SelectedIndex == 3)
            {
                pcbSnack4.Visible = true;
                pcbSnack2.Visible = false;
                pcbSnack3.Visible = false;
                pcbSnack1.Visible = false;
                alimentos.snack = "Hot Dog";
                alimentos.subTotal = 2.5;
            }
            if (cmbSnack.SelectedIndex == 4)
            {
                alimentos.snack = "Ninguno";
                pcbSnack1.Visible = false;
                pcbSnack2.Visible = false;
                pcbSnack3.Visible = false;
                pcbSnack4.Visible = false;
            }
        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbBebidas.SelectedIndex == 0)
            {
                pcbBebida1.Visible = true;
                pcbBebida2.Visible = false;
                pcbBebida3.Visible = false;
                pcbBebida4.Visible = false;
                alimentos.bebida = "Pepsi";
                alimentos.subTotal += 1 ;
            }
            if (cmbBebidas.SelectedIndex == 1)
            {
                pcbBebida2.Visible = true;
                pcbBebida1.Visible = false;
                pcbBebida3.Visible = false;
                pcbBebida4.Visible = false;
                alimentos.bebida = "7 Up";
                alimentos.subTotal += 1;
            }
            if (cmbBebidas.SelectedIndex == 2)
            {
                pcbBebida3.Visible = true;
                pcbBebida2.Visible = false;
                pcbBebida1.Visible = false;
                pcbBebida4.Visible = false;
                alimentos.bebida = "Granizado";
                alimentos.subTotal += 2;
            }
            if (cmbBebidas.SelectedIndex == 3)
            {
                pcbBebida4.Visible = true;
                pcbBebida2.Visible = false;
                pcbBebida3.Visible = false;
                pcbBebida1.Visible = false;
                alimentos.bebida = "NesTea";
                alimentos.subTotal += 1;
            }
           
        }

        private void Comida_Load(object sender, EventArgs e)
        {
            pcbSnack1.Visible = false;
            pcbSnack2.Visible = false;
            pcbSnack3.Visible = false;
            pcbSnack4.Visible = false;

            pcbBebida1.Visible = false;
            pcbBebida2.Visible = false;
            pcbBebida3.Visible = false;
            pcbBebida4.Visible = false;
        }

        private void btmSiguiente_Click(object sender, EventArgs e)
        {
        }
        void colocarPrecios()
        {
            if (chkCombo11.Checked == true)
            {
                alimentos.combos += "-Combo1-";
                alimentos.subTotal += 10;
            }
            if (chkCombo2.Checked == true)
            {
                alimentos.combos += "-Combo2-";
                alimentos.subTotal += 10;
            }
            if (chkCombo3.Checked == true)
            {
                alimentos.combos += "-Combo3-";
                alimentos.subTotal += 7;
            }
            if (chkCombo11.Checked == false && chkCombo2.Checked == false && chkCombo3.Checked == false)
            {
                alimentos.combos += "Ningun COMBO";
            }
        }
    }
}
