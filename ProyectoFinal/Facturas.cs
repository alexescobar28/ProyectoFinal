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
            public string CI;
            public string nombre;
            public string apellido;
            public string pelicula;
            public string butacas;
            public string fecha;
            public int sala;
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
            lblAsientos.Text=informacion.cantidadAsientos.ToString();
            lblSubtotalEntradas.Text="$"+informacion.subtotalEntradas.ToString();
            lblComida.Text=informacion.comida;
            lblSubtotalComida.Text = "$"+informacion.subTotalComida.ToString();
            informacion.TotalPagar = informacion.subTotalComida + informacion.subtotalEntradas;
            lblTotalPagar.Text = "$"+informacion.TotalPagar.ToString();
            lblSala.Text = informacion.sala.ToString();
        }
        void asignarVariables()
        {
            informacion.CI =Datos.CI;
            informacion.nombre= Datos.nombre;
            informacion.apellido = Datos.apellido;
            informacion.fecha = Datos.fecha;
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
    }
}
