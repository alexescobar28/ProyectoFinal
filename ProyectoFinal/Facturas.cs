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
    public partial class Facturas : Form
    {
        public struct Facturar
        {
            public String CI;
            public String nombre;
            public String apellido;
            public String pelicula;
            public String butacas;
            public String fecha;
            public int cantidadAsientos;
            public string comida;
            public double subtotalEntradas;
            public double subTotalComida;
            public double TotalPagar;
        }
        static public Facturar informacion;
        public Facturas()
        {
            InitializeComponent();
            asignarVariables();
            lblCedula.Text = informacion.CI;
            lblNombre.Text = informacion.nombre;
            lblApellido.Text = informacion.apellido;
            lblPelicula.Text = informacion.pelicula;
            lblFecha.Text = informacion.fecha;
            lblButacas.Text = informacion.butacas;
        }
        void asignarVariables()
        {
            informacion.CI =Datos.CI;
            informacion.nombre= Datos.nombre;
            informacion.apellido = Datos.apellido;
            informacion.fecha = Datos.fecha;
            informacion.pelicula = Datos.pelicula;
            informacion.butacas = Datos.butacas;
        }
    }
}
