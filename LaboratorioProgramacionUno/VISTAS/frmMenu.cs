using _LaboratorioProgramacionUno_.DOMINIO;
using _LaboratorioProgramacionUno_.NEGOCIO;
using _LaboratorioProgramacionUno_.VISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LaboratorioProgramacionUno_
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.Estado = 0;

            frmLoguin frm = new frmLoguin();
            this.Hide();
            frm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Estado = 1;

            frmLoguin frm = new frmLoguin();
            this.Hide();
            frm.Show();
        }
    }
}
