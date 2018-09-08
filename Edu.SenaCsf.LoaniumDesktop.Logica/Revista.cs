using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Revista : Material {
        private string issn;

        public Revista() : base() {
        }

        public Revista(string issn) /* const padre*/ {
            this.Issn = issn;
        }

        public string Issn { get => issn; set => issn = value; }

        public override void EliminarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void IngresarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public override void ModificarMaterial(Material m) {
            throw new NotImplementedException();
        }

        public List<Material> MostrarTodas() {
            return new List<Material>();
        }
    }
}
