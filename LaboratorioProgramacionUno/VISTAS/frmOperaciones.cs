using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LaboratorioProgramacionUno_.VISTAS
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double iva = Convert.ToDouble(txtIva.Text);
            string nombreProducto = txtNombreProducto.Text;
            double precio = Convert.ToDouble(txtPrecioProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            double descuento = 0;
            double precioFinal = 0;

            lblProducto.Text = nombreProducto.ToString();

            if (precio <= 50)
            {
                
            }
            else if (precio > 50 && precio < 100)
            {
                descuento = precio * 0.05;
            }
            else if (precio >= 100 && precio < 101)
            {
                descuento = precio * 0.10;
            }
            else if (precio >= 101 && precio < 150)
            {
                descuento = precio * 0.20;
            }
            else if (precio > 150)
            {
                descuento = precio * 0.50;
            }

            precioFinal = precio * cantidad;
            lblTSinIva.Text = precioFinal.ToString();

            double IvaAgregar =  iva * precioFinal;
            lblIvaAgregar.Text = IvaAgregar.ToString();

            double tSDescuentoCIva = precioFinal + IvaAgregar;
            lblConIva.Text = tSDescuentoCIva.ToString();

            /*double des = tSDescuentoCIva * descuento;
            double TotalAPagar = tSDescuentoCIva - des;*/
            double TotalAPagar = tSDescuentoCIva - descuento;
            lblTotalAPagar.Text = TotalAPagar.ToString();
            lblProducto.Text = nombreProducto;
        }
        public string usuarioEstado;
        private void frmOperaciones_Load(object sender, EventArgs e)
        {
            lblNombre.Text = usuarioEstado;
        }
    }
}
