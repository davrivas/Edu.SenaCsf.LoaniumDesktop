using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class PrestamoDTO {
        private int id;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private EstadoPrestamoDTO estadoPrestamo;
        private UsuarioDTO usuario;
        private List<MaterialDTO> materiales;

        public PrestamoDTO() {
        }

        public PrestamoDTO(int id, DateTime fechaPrestamo, DateTime fechaDevolucion, EstadoPrestamoDTO estadoPrestamo, UsuarioDTO usuario, List<MaterialDTO> materiales) {
            this.Id = id;
            this.FechaPrestamo = fechaPrestamo;
            this.FechaDevolucion = fechaDevolucion;
            this.EstadoPrestamo = estadoPrestamo;
            this.Usuario = usuario;
            this.Materiales = materiales;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public EstadoPrestamoDTO EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        public UsuarioDTO Usuario { get => usuario; set => usuario = value; }
        public List<MaterialDTO> Materiales { get => materiales; set => materiales = new List<MaterialDTO>(3); }
    }
}
