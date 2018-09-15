using Edu.SenaCsf.LoaniumDesktop.Datos.Conexion;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.Sesion {
    public class SesionControlador {
        private static UsuarioDTO usuario;

        public static UsuarioDTO Usuario { get => usuario; set => usuario = value; }

        public static void Iniciar() {
            Conexion.Abrir();
        }
    }
}
