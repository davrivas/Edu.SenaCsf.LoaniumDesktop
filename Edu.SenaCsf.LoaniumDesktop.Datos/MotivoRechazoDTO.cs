using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class MotivoRechazoDTO {
        private int id;
        private string motivo;

        public MotivoRechazoDTO() {
        }

        public MotivoRechazoDTO(int id, string motivo) {
            this.Id = id;
            this.Motivo = motivo;
        }

        public int Id { get => id; set => id = value; }
        public string Motivo { get => motivo; set => motivo = value; }
    }
}
