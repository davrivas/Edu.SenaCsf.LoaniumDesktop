using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica.DAO.InterfacesDAO {
    public interface IPQRSDAO : IDAO<PQRSDTO> {
        void ResponderPQRS(PQRSDTO pqrs);
    }
}
