using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class UsuarioDAO {
        public void IniciarSesion(String documento, String clave) { }

        public void CerrarSesion() { }

        public void EditarPerfil(UsuarioDAO u) { }

        public void CambiarClave(UsuarioDAO u) { }

        public void SuspenderCuenta(UsuarioDAO u) { }

        public void SuspenderUsuario(UsuarioDAO u) { }

        public void ReactivarUsuario(UsuarioDAO u) { }

        public void InsertarUsuario(UsuarioDAO u) { }

        public List<UsuarioDAO> MostrarNoBloqueados() {
            return null;
        }

        public List<UsuarioDAO> MostrarBloqueados() {
            return null;
        }
    }
}
