using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class MotivoRechazo {
        private int id;
        private string motivo;

        public MotivoRechazo() {
        }

        public MotivoRechazo(int id, string motivo) {
            this.Id = id;
            this.Motivo = motivo;
        }

        public int Id { get => id; set => id = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        public List<MotivoRechazo> MostrarTodos() {
            return new List<MotivoRechazo>();
        }
    }
}
