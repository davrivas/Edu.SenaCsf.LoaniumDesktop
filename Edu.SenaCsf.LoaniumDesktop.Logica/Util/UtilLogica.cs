using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.UtilLogica {
    public class UtilLogica {
        private static UsuarioDTO usuarioSesion;

        public static UsuarioDTO UsuarioSesion { get => usuarioSesion; set => usuarioSesion = value; }
    }
}
