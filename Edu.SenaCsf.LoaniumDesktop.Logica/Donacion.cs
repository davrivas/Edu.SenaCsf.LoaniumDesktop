using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    class Donacion {
        private int id;
        private DateTime fecha;
        private string otroMotivoRechazo;
        private EstadoDonacion estadoDonacion;
        private List<EjemplarMaterial> ejemplares;
        private List<MotivoRechazo> motivosRechazo;

        public Donacion() {
        }

        public Donacion(int id, DateTime fecha, EstadoDonacion estadoDonacion, List<EjemplarMaterial> ejemplares) {
            this.Id = id;
            this.Fecha = fecha;
            this.EstadoDonacion = estadoDonacion;
            this.Ejemplares = ejemplares;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string OtroMotivoRechazo { get => otroMotivoRechazo; set => otroMotivoRechazo = value; }
        public EstadoDonacion EstadoDonacion { get => estadoDonacion; set => estadoDonacion = value; }
        internal List<EjemplarMaterial> Ejemplares { get => ejemplares; set => ejemplares = value; }
        internal List<MotivoRechazo> MotivosRechazos { get => motivosRechazo; set => motivosRechazo = value; }

        public void AprobarDonacion(Donacion d) { }

        public void RechazarDonacion(Donacion d) { }

        public void InsertarDonacion(Donacion d) { }

        public void EditarDonacion(Donacion d) { }

        public List<Donacion> MostrarTodas() {
            return new List<Donacion>();
        }

        public List<Donacion> MostrarPorUsuario(Usuario u) {
            return new List<Donacion>();
        }
    }
}
