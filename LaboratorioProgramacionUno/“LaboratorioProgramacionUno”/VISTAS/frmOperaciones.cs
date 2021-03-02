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
            double TotalsinIva = 0;

            lblProducto.Text = nombreProducto.ToString();

            if (precio <= 50)
            {
                descuento = 0.0;
            }
            else if (precio > 50 && precio < 100)
            {
                descuento = 0.05;
            }
            else if (precio >= 100 && precio < 101)
            {
                descuento =  0.10;
            }
            else if (precio >= 101 && precio < 150)
            {
                descuento =  0.20;
            }
            else if (precio > 150)
            {
                descuento =  0.50;
            }

            TotalsinIva = (precio * cantidad); //   101
            lblTSinIva.Text = TotalsinIva.ToString();

            double IvaAgregar = (TotalsinIva * iva); // 101 *0.10  = 10.1
            lblIvaAgregar.Text = IvaAgregar.ToString();

            double tSDescuentoCIva = TotalsinIva + IvaAgregar; // precio = 101 + iva = 10.1 = 111.1
            lblConIva.Text = tSDescuentoCIva.ToString();

            /*double des = tSDescuentoCIva * descuento;
            double TotalAPagar = tSDescuentoCIva - des;*/
            double TotalAPagar = tSDescuentoCIva - (tSDescuentoCIva * descuento); // 111.1 - (111.1 * 0.20)
            lblTotalAPagar.Text = TotalAPagar.ToString();                         // 11.1 - 22.22 ---> 88.88
            lblProducto.Text = nombreProducto;
        }
        public string usuarioEstado;
        private void frmOperaciones_Load(object sender, EventArgs e)
        {
            lblNombre.Text = usuarioEstado;
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRÁ DESCUENTO","<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRÁ UN DESCUENTO DEL 0.05"," >50 and <100 ");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRÁ UN DESCUENTO DEL 0.10 "," >= 100 and < 101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRÁ UN DESCUENTO DEL 0.20", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50", "> 150");
            
        }
    }
}
