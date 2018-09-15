using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos {
    public class DonacionDTO {
        private int id;
        private DateTime fecha;
        private string motivoRechazo;
        private EstadoDonacionDTO estadoDonacion;
        private UsuarioDTO usuario;
        private List<MaterialDTO> materiales;
        
        public DonacionDTO() {
        }

        public DonacionDTO(int id, DateTime fecha, string motivoRechazo, EstadoDonacionDTO estadoDonacion, UsuarioDTO usuario, List<MaterialDTO> materiales) {
            this.Id = id;
            this.Fecha = fecha;
            this.MotivoRechazo = motivoRechazo;
            this.EstadoDonacion = estadoDonacion;
            this.Usuario = usuario;
            this.Materiales = materiales;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string MotivoRechazo { get => motivoRechazo; set => motivoRechazo = value; }
        public EstadoDonacionDTO EstadoDonacion { get => estadoDonacion; set => estadoDonacion = value; }
        public UsuarioDTO Usuario { get => usuario; set => usuario = value; }
        public List<MaterialDTO> Materiales { get => materiales; set => materiales = new List<MaterialDTO>(); }
    }
}
