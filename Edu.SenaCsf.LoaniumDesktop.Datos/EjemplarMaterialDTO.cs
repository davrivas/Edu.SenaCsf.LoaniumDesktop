using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class EjemplarMaterial {
        private int id;
        private string numeroTopografico;
        private EstadoMaterial estadoMaterial;

        public EjemplarMaterial() {
        }

        public EjemplarMaterial(int id, string numeroTopografico, EstadoMaterial estadoMaterial) {
            this.Id = id;
            this.NumeroTopografico = numeroTopografico;
            this.EstadoMaterial = estadoMaterial;
        }

        public int Id { get => id; set => id = value; }
        public string NumeroTopografico { get => numeroTopografico; set => numeroTopografico = value; }
        internal EstadoMaterial EstadoMaterial { get => estadoMaterial; set => estadoMaterial = value; }

        public void IngresarEjemplar(EjemplarMaterial em) { }

        public void ModificarEjemplar(EjemplarMaterial em) { }

        public void EliminarEjemplar(EjemplarMaterial em) { }

        public List<EjemplarMaterial> MostrarEjemplares(Material m) {
            return new List<EjemplarMaterial>();
        }
    }
}
