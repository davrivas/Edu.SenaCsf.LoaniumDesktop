using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Observacion {
        private int id;
        private string detalle;

        public Observacion() {
        }

        public Observacion(int id, string detalle) {
            this.Id = id;
            this.Detalle = detalle;
        }

        public int Id { get => id; set => id = value; }
        public string Detalle { get => detalle; set => detalle = value; }

        public void IngresarObservacion(Observacion o) { }

        public List<Observacion> MostrarTodas() {
            return new List<Observacion>();
        }

        public List<Observacion> MostrarTodasPorPrestamos(Prestamo p) {
            return new List<Observacion>();
        }
    }
}
