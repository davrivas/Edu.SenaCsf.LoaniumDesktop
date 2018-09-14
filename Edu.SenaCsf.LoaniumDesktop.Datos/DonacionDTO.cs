using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class DonacionDTO {
        private int id;
        private DateTime fecha;
        private EstadoDonacionDTO estadoDonacion;
        private List<MaterialDTO> materiales;
        private MotivoRechazoDTO motivoRechazo;
        private string otroMotivoRechazo;

        public DonacionDTO() {
        }

        public DonacionDTO(int id, DateTime fecha, EstadoDonacionDTO estadoDonacion, List<MaterialDTO> materiales, MotivoRechazoDTO motivoRechazo, string otroMotivoRechazo) {
            this.Id = id;
            this.Fecha = fecha;
            this.EstadoDonacion = estadoDonacion;
            this.Materiales = materiales;
            this.MotivoRechazo = motivoRechazo;
            this.OtroMotivoRechazo = otroMotivoRechazo;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public EstadoDonacionDTO EstadoDonacion { get => estadoDonacion; set => estadoDonacion = value; }
        public List<MaterialDTO> Materiales { get => materiales; set => materiales = new List<MaterialDTO>(); }
        public MotivoRechazoDTO MotivoRechazo { get => motivoRechazo; set => motivoRechazo = value; }
        public string OtroMotivoRechazo { get => otroMotivoRechazo; set => otroMotivoRechazo = value; }
    }
}
