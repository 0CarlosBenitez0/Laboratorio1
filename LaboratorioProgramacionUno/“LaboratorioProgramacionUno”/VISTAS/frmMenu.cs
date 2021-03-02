using _LaboratorioProgramacionUno_.DOMINIO;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        frmLoguin frm = new frmLoguin();
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            
            frm.lblPrueba.Text = 0.ToString();

            this.Hide();
            frm.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {

            frm.lblPrueba.Text = 1.ToString();

            this.Hide();
            frm.Show();
        }
    }
}
