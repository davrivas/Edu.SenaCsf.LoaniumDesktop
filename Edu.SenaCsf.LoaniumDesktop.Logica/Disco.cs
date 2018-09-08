using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Disco : Material {
        private int duracion;

        public Disco() : base() {
        }

        public Disco(int duracion) /* const padre*/ {
            this.Duracion = duracion;
        }

        public int Duracion { get => duracion; set => duracion = value; }

        public override void EliminarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void IngresarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void ModificarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public List<Disco> MostrarTodos() {
            return new List<Disco>();
        }
    }
}
