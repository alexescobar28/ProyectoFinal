﻿using System;
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
    public partial class frmFacturas : Form
    {
        public struct Facturacion
        {
            public string CI;
            public string nombre;
            public string apellido;
            public string pelicula;
            public string butacas;
            public string fecha;
            public string hora;
            public int sala;
            public int cantidadAsientos;
            public string comida;
            public double subtotalEntradas;
            public double subTotalComida;
            public double TotalPagar;
        }
        static public Facturacion informacion;
        public frmFacturas()
        {
            InitializeComponent();
            AsignarVariables();
            lblCedula.Text = informacion.CI;
            lblNombre.Text = informacion.nombre;
            lblApellido.Text = informacion.apellido;
            lblPelicula.Text = informacion.pelicula;
            lblFecha.Text = informacion.fecha;
            lblHora.Text = informacion.hora;
            lblButacas.Text = informacion.butacas;
            lblAsientos.Text=informacion.cantidadAsientos.ToString();
            lblSala.Text = informacion.sala.ToString();
            lblSubtotalEntradas.Text="$"+informacion.subtotalEntradas.ToString();
            lblComida.Text=informacion.comida;
            lblSubtotalComida.Text = "$"+informacion.subTotalComida.ToString();
            informacion.TotalPagar = informacion.subTotalComida + informacion.subtotalEntradas;//calcular el total a pagar
            lblTotalPagar.Text = "$"+informacion.TotalPagar.ToString();
            
        }
        public void AsignarVariables()
        {
            informacion.CI =Datos.CI;
            informacion.nombre= Datos.nombre;
            informacion.apellido = Datos.apellido;
            informacion.fecha = Datos.fecha;
            informacion.hora= Datos.hora;   
            informacion.pelicula = Datos.pelicula;
            informacion.butacas = Datos.butacas;
            informacion.cantidadAsientos = Datos.contadorAsientos;
            informacion.subtotalEntradas= Datos.subtotalEntradas;
            informacion.comida = Datos.comida;
            informacion.subTotalComida = Datos.subtotalComidas;
            Random aleatorio=new Random();
            int numero;
            numero=aleatorio.Next(1,11);
            informacion.sala = numero;
        }

        private void Facturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
