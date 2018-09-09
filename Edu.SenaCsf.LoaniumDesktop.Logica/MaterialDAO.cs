using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica.InterfacesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public class MaterialDAO : IMaterialDAO {
        public MaterialDAO() {
        }

        public MaterialDTO BuscarPorId(int id) {
            throw new NotImplementedException();
        }

        public List<MaterialDTO> BusquedaAvanzada(string texto, IdiomaDTO i, TipoMaterialDTO tm) {
            throw new NotImplementedException();
        }

        public List<MaterialDTO> BusquedaSimple(string texto) {
            throw new NotImplementedException();
        }

        public void Editar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(MaterialDTO obj) {
            throw new NotImplementedException();
        }

        public List<MaterialDTO> MostrarTodos() {
            throw new NotImplementedException();
        }
    }
}
