using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class TipoUsuario {
        private int id;
        private string tipo;
        private List<Permiso> permisos;

        public TipoUsuario() {
        }

        public TipoUsuario(int id, string tipo, List<Permiso> permisos) {
            this.Id = id;
            this.Tipo = tipo;
            this.Permisos = permisos;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        internal List<Permiso> Permisos { get => permisos; set => permisos = value; }

        public List<TipoUsuario> MostrarTodos() {
            return new List<TipoUsuario>();
        }
    }
}
