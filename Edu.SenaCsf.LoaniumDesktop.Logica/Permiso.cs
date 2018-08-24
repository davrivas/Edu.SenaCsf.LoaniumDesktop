using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Permiso {
        private int id;
        private string nombrePermiso;
        private string url;

        public Permiso() {
        }

        public Permiso(int id, string nombrePermiso, string url) {
            this.Id = id;
            this.NombrePermiso = nombrePermiso;
            this.Url = url;
        }

        public int Id { get => id; set => id = value; }
        public string NombrePermiso { get => nombrePermiso; set => nombrePermiso = value; }
        public string Url { get => url; set => url = value; }

        public List<Permiso> MostrarTodos(TipoUsuario tu) {
            return new List<Permiso>();
        }
    }
}
