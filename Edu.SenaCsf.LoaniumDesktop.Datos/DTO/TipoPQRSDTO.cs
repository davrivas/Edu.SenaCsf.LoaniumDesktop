using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class TipoPQRSDTO {
        private int id;
        private string tipo;

        public TipoPQRSDTO() {
        }

        public TipoPQRSDTO(int id, string tipo) {
            this.Id = id;
            this.Tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
