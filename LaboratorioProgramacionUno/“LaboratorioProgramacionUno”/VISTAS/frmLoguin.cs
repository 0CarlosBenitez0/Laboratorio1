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
//        frmLoguin frmlog = new frmLoguin();

        public int estado;
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            Login log = new Login();
            log.Usuario = txtNombre.Text;
            log.Password = txtPass.Text;
            log.Estado = this.estado;
            

            clsLogin cls = new clsLogin();
            int variabledeevaluacion = cls.Acceso(log);

            if (variabledeevaluacion == 1 && estado == 0)
            {
                frmOperaciones frm = new frmOperaciones();
                frm.usuarioEstado = txtNombre.Text;

                MessageBox.Show("Bienvenido/a " + txtNombre.Text);

                this.Hide();
                frm.Show();

                frm.txtIva.Enabled = false;
                frm.txtNombreProducto.Enabled = false;
            }
            else if (variabledeevaluacion == 1 && estado == 1)
            {
                frmOperaciones frm = new frmOperaciones();

                frm.usuarioEstado = txtNombre.Text;
                MessageBox.Show("Bienvenido/a " + txtNombre.Text);

                this.Hide();
                frm.Show();
            }
            else {
                MessageBox.Show("Datos incorrectos");
            }
            lblPrueba.Text = log.Estado.ToString();
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(lblPrueba.Text);
            if (estado == 1)
            {
                this.Text = "Login de Administradores";
            }
        }
    }
}
