using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class UsuarioDAO : IUsuarioDAO {
        public UsuarioDAO() {
        }

        public UsuarioDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public void CambiarClave(UsuarioDTO u, string claveActual, string claveNueva, string confirmacion) {
            throw new NotImplementedException();
        }

        public void CerrarSesion() {
            throw new NotImplementedException();
        }

        public void Editar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void EditarPerfil(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void Eliminar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void IniciarSesion(TipoDocumentoDTO td, string documento, string clave) {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> MostrarNoSuspendidos(EstadoUsuarioDTO eu) {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> MostrarSuspendidos(EstadoUsuarioDTO eu) {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> MostrarTodos() {
            throw new NotImplementedException();
        }

        public void ReactivarCuenta(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void ReactivarUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void SuspenderCuenta(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void SuspenderUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }
    }
}
