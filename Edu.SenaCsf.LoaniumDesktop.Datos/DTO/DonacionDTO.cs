using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Datos.DTO {
    public class DonacionDTO {
        private int id;
        private DateTime fecha;
        private string motivoRechazo; // Opcional
        private EstadoDonacionDTO estadoDonacion;
        private UsuarioDTO usuario;
        private MaterialDTO material;
        
        public DonacionDTO() {
        }

        public DonacionDTO(int id, DateTime fecha, string motivoRechazo, EstadoDonacionDTO estadoDonacion, UsuarioDTO usuario, MaterialDTO material) {
            this.Id = id;
            this.Fecha = fecha;
            this.MotivoRechazo = motivoRechazo;
            this.EstadoDonacion = estadoDonacion;
            this.Usuario = usuario;
            this.Material = material;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string MotivoRechazo { get => motivoRechazo; set => motivoRechazo = value; }
        public EstadoDonacionDTO EstadoDonacion { get => estadoDonacion; set => estadoDonacion = value; }
        public UsuarioDTO Usuario { get => usuario; set => usuario = value; }
        public MaterialDTO Material { get => material; set => material = value; }
    }
}
