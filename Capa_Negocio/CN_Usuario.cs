using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Usuario
    {
        public static SQLBaseLinqDataContext dcBase = new SQLBaseLinqDataContext();
        public static bool VerificarUsuario(string nomLogin) {
            var usuario = dcBase.Tbl_Usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_nomLogin.Equals(nomLogin));
            return usuario;
        }
        public static bool VerificarContra(string conLogin)
        {
            var usuario = dcBase.Tbl_Usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_contraLogin.Equals(conLogin));
            return usuario;
        }
        public static bool VerificarUsuContra(string nomLogin,string conLogin)
        {
            var usuario = dcBase.Tbl_Usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_nomLogin.Equals(nomLogin));
            return usuario;
        }       
    }
}
