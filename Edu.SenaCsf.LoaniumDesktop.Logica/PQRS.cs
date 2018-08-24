using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class PQRS {
        private int id;
        private string remitente;
        private string mensaje;
        private string respuesta;
        private TipoPQRS tipoPQRS;
        private EstadoPQRS estadoPQRS;
        private Usuario usuario;

        public PQRS() {
        }

        public PQRS(int id, string remitente, string mensaje, TipoPQRS tipoPQRS, EstadoPQRS estadoPQRS) {
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
        internal TipoPQRS TipoPQRS { get => tipoPQRS; set => tipoPQRS = value; }
        internal EstadoPQRS EstadoPQRS { get => estadoPQRS; set => estadoPQRS = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public void IngresarPQRS(PQRS pqrs) { }

        public void ResponderPQRS(PQRS pqrs) { }
    }
}
