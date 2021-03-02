using _LaboratorioProgramacionUno_.DOMINIO;
using _LaboratorioProgramacionUno_.NEGOCIO;
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
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.Usuario = txtNombre.Text;
            log.Password = txtPass.Text;

            clsLogin cls = new clsLogin();

            int variabledeevaluacion = cls.Acceso(log);

            if (variabledeevaluacion == 1 && log.Estado == 0)
            {
                frmOperaciones frm = new frmOperaciones();
                frm.usuarioEstado = txtNombre.Text;

                MessageBox.Show("Enter");

                this.Hide();
                frm.Show();

                frm.txtIva.Enabled = false;
                frm.txtNombreProducto.Enabled = false;
            }
            else if (variabledeevaluacion == 1 && log.Estado == 1)
            {
                frmOperaciones frm = new frmOperaciones();

                frm.usuarioEstado = txtNombre.Text;
                MessageBox.Show("Enter");

                this.Hide();
                frm.Show();
            }
            else {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
