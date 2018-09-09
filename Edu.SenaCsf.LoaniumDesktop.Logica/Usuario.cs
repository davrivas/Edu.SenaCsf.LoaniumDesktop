using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class Usuario {
        public void IniciarSesion(String documento, String clave) { }

        public void CerrarSesion() { }

        public void EditarPerfil(Usuario u) { }

        public void CambiarClave(Usuario u) { }

        public void SuspenderCuenta(Usuario u) { }

        public void SuspenderUsuario(Usuario u) { }

        public void ReactivarUsuario(Usuario u) { }

        public void InsertarUsuario(Usuario u) { }

        public List<Usuario> MostrarNoBloqueados() {
            return null;
        }

        public List<Usuario> MostrarBloqueados() {
            return null;
        }
    }
}
