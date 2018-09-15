using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class SuspensionDTO {
        private int id;
        private DateTime fecha;
        private string detalle;
        private PrestamoDTO prestamos;

        public SuspensionDTO() {
        }

        public SuspensionDTO(int id, DateTime fecha, string detalle, PrestamoDTO prestamos) {
            this.Id = id;
            this.Fecha = fecha;
            this.Detalle = detalle;
            this.Prestamos = prestamos;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public PrestamoDTO Prestamos { get => prestamos; set => prestamos = value; }
    }
}
