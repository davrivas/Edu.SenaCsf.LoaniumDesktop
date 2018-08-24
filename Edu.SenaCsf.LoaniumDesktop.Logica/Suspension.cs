using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Suspension {
        private int id;
        private DateTime fecha;
        private string detalle;
        private List<Prestamo> prestamos;

        public Suspension() {
        }

        public Suspension(int id, DateTime fecha, string detalle) {
            this.Id = id;
            this.Fecha = fecha;
            this.Detalle = detalle;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        internal List<Prestamo> Prestamos { get => prestamos; set => prestamos = value; }

        public List<Suspension> MostrarTodas() {
            return new List<Suspension>();
        }
    }
}
