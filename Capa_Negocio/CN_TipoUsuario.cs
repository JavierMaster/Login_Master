using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_TipoUsuario
    {
        public static SQLBaseLinqDataContext cdLinq = new SQLBaseLinqDataContext();

        public static bool UsuarioAdmin(string nomLogin,string contraLogin) {
            var Usu = cdLinq.Tbl_Usuario.Any(log=> log.usu_estado == 'A' & log.usu_nomLogin.Equals(nomLogin) & log.usu_contraLogin.Equals(contraLogin) & log.usu_tipo == 2);
            return Usu;
        }
    }
}
