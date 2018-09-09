using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.SenaCsf.LoaniumDesktop.Logica {
    public abstract class MaterialDTO {
        private int id;
        private string titulo;
        private string autor;
        private DateTime fechaPublicacion;
        private string descripcion;
        private IdiomaDTO idioma;
        private TipoMaterialDTO tipoMaterial;
        private List<EjemplarMaterialDTO> ejemplares;
        private List<TematicaDTO> tematicas;
    }
}
