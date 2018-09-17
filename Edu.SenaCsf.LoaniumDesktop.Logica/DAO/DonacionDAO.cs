using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO {
    public class DonacionDAO : IDonacionDAO {
        public DonacionDAO() {
        }

        public void AprobarDonacion(DonacionDTO d) {
            throw new NotImplementedException();
        }

        public DonacionDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public int Contar() {
            throw new NotImplementedException();
        }

        public void Editar(DonacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(DonacionDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(DonacionDTO obj) {
            throw new NotImplementedException();
        }

        public List<DonacionDTO> MostrarAprobadas(EstadoDonacionDTO ed) {
            throw new NotImplementedException();
        }

        public List<DonacionDTO> MostrarNoAprobadas(EstadoDonacionDTO ed) {
            throw new NotImplementedException();
        }

        public List<DonacionDTO> MostrarPorUsuario(UsuarioDTO u) {
            throw new NotImplementedException();
        }

        public void RechazarDonacion(DonacionDTO d) {
            throw new NotImplementedException();
        }
    }
}
