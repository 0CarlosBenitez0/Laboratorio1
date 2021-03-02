using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LaboratorioProgramacionUno_.DOMINIO
{
    class Login
    {
        private string usuario;
        private string password;
        private int estado;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
