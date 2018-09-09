using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class EjemplarMaterialDTO {
        private int id;
        private string numeroTopografico;
        private EstadoMaterialDTO estadoMaterial;

        public EjemplarMaterialDTO() {
        }

        public EjemplarMaterialDTO(int id, string numeroTopografico, EstadoMaterialDTO estadoMaterial) {
            this.Id = id;
            this.NumeroTopografico = numeroTopografico;
            this.EstadoMaterial = estadoMaterial;
        }

        public int Id { get => id; set => id = value; }
        public string NumeroTopografico { get => numeroTopografico; set => numeroTopografico = value; }
        public EstadoMaterialDTO EstadoMaterial { get => estadoMaterial; set => estadoMaterial = value; }
    }
}
