using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Prestamo {
        private int id;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private EstadoPrestamo estadoPrestamo;
        private Usuario usuario;
        private List<EjemplarMaterial> ejemplares;
        private List<Observacion> observaciones;

        public Prestamo() {
        }

        public Prestamo(int id, DateTime fechaPrestamo, DateTime fechaDevolucion, EstadoPrestamo estadoPrestamo, Usuario usuario, List<EjemplarMaterial> ejemplares) {
            this.Id = id;
            this.FechaPrestamo = fechaPrestamo;
            this.FechaDevolucion = fechaDevolucion;
            this.EstadoPrestamo = estadoPrestamo;
            this.Usuario = usuario;
            this.Ejemplares = ejemplares;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public EstadoPrestamo EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal List<EjemplarMaterial> Ejemplares { get => ejemplares; set => ejemplares = value; }
        internal List<Observacion> Observaciones { get => observaciones; set => observaciones = value; }

        public void SolicitarPrestamo(Prestamo p) { }

        public List<Prestamo> MostrarTodos() {
            return new List<Prestamo>();
        }

        public List<Prestamo> MostrarPorUsuario(Usuario u) {
            return new List<Prestamo>();
        }
    }
}
