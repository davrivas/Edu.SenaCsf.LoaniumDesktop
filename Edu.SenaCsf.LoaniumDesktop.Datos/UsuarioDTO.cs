using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class UsuarioDTO {
        private int id;
        private string nombres;
        private string apellidos;
        private string documento;
        private DateTime fechaNacimiento;
        private string correoElectronico;
        private string clave;
        private string telefono;
        private TipoDocumentoDTO tipoDocumento;
        private TipoUsuarioDTO tipoUsuario;
        private EstadoUsuarioDTO estadoUsuario;

        public UsuarioDTO() {
        }

        public UsuarioDTO(int id, string nombres, string apellidos, string documento, DateTime fechaNacimiento, string correoElectronico, string clave, string telefono, TipoDocumentoDTO tipoDocumento, TipoUsuarioDTO tipoUsuario, EstadoUsuarioDTO estadoUsuario) {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Documento = documento;
            this.FechaNacimiento = fechaNacimiento;
            this.CorreoElectronico = correoElectronico;
            this.Clave = clave;
            this.Telefono = telefono;
            this.TipoDocumento = tipoDocumento;
            this.TipoUsuario = tipoUsuario;
            this.EstadoUsuario = estadoUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Documento { get => documento; set => documento = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public TipoDocumentoDTO TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public TipoUsuarioDTO TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public EstadoUsuarioDTO EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
    }
}
