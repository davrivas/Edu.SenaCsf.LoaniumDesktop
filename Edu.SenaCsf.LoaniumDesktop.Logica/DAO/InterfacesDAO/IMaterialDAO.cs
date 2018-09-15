using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO {
    public interface IMaterialDAO : IDAO<MaterialDTO> {
        List<MaterialDTO> BusquedaSimple(string texto);
        List<MaterialDTO> BusquedaAvanzada(string texto, IdiomaDTO i, TipoMaterialDTO tm);
    }
}
