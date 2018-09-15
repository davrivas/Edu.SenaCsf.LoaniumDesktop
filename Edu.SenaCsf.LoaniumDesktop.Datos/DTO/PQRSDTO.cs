using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class PQRSDTO {
        private int id;
        private string remitente;
        private string mensaje;
        private string respuesta; // Cuando se responde PQRS
        private TipoPQRSDTO tipoPQRS;
        private EstadoPQRSDTO estadoPQRS;
        private UsuarioDTO usuario;

        public PQRSDTO() {
        }

        public PQRSDTO(int id, string remitente, string mensaje, TipoPQRSDTO tipoPQRS, EstadoPQRSDTO estadoPQRS) {
            this.Id = id;
            this.Remitente = remitente;
            this.Mensaje = mensaje;
            this.TipoPQRS = tipoPQRS;
            this.EstadoPQRS = estadoPQRS;
        }

        public int Id { get => id; set => id = value; }
        public string Remitente { get => remitente; set => remitente = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public TipoPQRSDTO TipoPQRS { get => tipoPQRS; set => tipoPQRS = value; }
        public EstadoPQRSDTO EstadoPQRS { get => estadoPQRS; set => estadoPQRS = value; }
        public UsuarioDTO Usuario { get => usuario; set => usuario = value; }
    }
}
