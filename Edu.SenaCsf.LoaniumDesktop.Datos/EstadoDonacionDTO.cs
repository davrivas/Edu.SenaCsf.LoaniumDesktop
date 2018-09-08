using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica
{
    public class EstadoDonacion {
        private int id;
        private String estado;

        public EstadoDonacion() {
        }

        public EstadoDonacion(int id, string estado) {
            this.Id = id;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
