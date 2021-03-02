using _LaboratorioProgramacionUno_.DAO;
using _LaboratorioProgramacionUno_.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LaboratorioProgramacionUno_.NEGOCIO
{
    class clsLogin
    {
        listaDeAdministradores listA = new listaDeAdministradores();
        listaDeUsuarios list = new listaDeUsuarios();

        int varAcceso = 0;

        public int Acceso(Login log)
        {

            if (log.Estado == 0)
            {
                for (int i = 0; i < list.nombreUsu.Length; i++)
                {
                    if (log.Usuario.Equals(list.nombreUsu[i]) && log.Password.Equals(list.passwordUsu[i]))
                    {
                        varAcceso = 1;
                    }
                }
            }
            else if (log.Estado == 1)
            {
                for (int j = 0; j < listA.nombreAdmin.Length; j++)
                {
                    if (log.Usuario.Equals(listA.nombreAdmin[j]) && log.Password.Equals(listA.passwordAdmin[j]))
                    {
                        varAcceso = 1;
                    }
                }
            }
            else
            {
                return 0;
            }
            return varAcceso;
        }
    }
}
