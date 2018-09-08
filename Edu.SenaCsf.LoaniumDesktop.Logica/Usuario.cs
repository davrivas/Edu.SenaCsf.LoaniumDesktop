using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Usuario {
        private int id;
        private string nombres;
        private string apellidos;
        private string documento;
        private string correoElectronico;
        private string clave;
        private string telefono;
        private TipoDocumento tipoDocumento;
        private TipoUsuario tipoUsuario;
        private EstadoUsuario estadoUsuario;

        public Usuario() {
        }

        public Usuario(int id, string nombres, string apellidos, string documento, string correoElectronico, string clave, TipoDocumento tipoDocumento, TipoUsuario tipoUsuario, EstadoUsuario estadoUsuario) {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Documento = documento;
            this.CorreoElectronico = correoElectronico;
            this.Clave = clave;
            this.TipoDocumento = tipoDocumento;
            this.TipoUsuario = tipoUsuario;
            this.EstadoUsuario = estadoUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Documento { get => documento; set => documento = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        internal TipoDocumento TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        internal TipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        internal EstadoUsuario EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        public void IniciarSesion(String documento, String clave) { }

        public void CerrarSesion() { }

        public void EditarPerfil(Usuario u) { }

        public void CambiarClave(Usuario u) { }

        public void SuspenderCuenta(Usuario u) { }

        public void SuspenderUsuario(Usuario u) { }

        public void ReactivarUsuario(Usuario u) { }

        public void InsertarUsuario(Usuario u) { }

        public List<Usuario> MostrarNoBloqueados() {
            return new List<Usuario>();
        }

        public List<Usuario> MostrarBloqueados() {
            return new List<Usuario>();
        }
    }
}
