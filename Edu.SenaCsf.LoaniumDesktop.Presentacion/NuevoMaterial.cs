using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion {
    public partial class NuevoMaterial : Form {
        public NuevoMaterial() {
            InitializeComponent();
        }

        private void NuevoMaterial_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tematicaSet.Tematica' table. You can move, or remove it, as needed.
            this.tematicaTableAdapter1.Fill(this.tematicaSet.Tematica);
            // TODO: This line of code loads data into the 'loaniumDataSet.Tematica' table. You can move, or remove it, as needed.
            this.tematicaTableAdapter.Fill(this.tematicaDataSet.Tematica);
            // TODO: This line of code loads data into the 'idiomaDataSet.Idioma' table. You can move, or remove it, as needed.
            this.idiomaTableAdapter.Fill(this.idiomaDataSet.Idioma);
            // TODO: This line of code loads data into the 'tipoMaterialDataSet.TipoMaterial' table. You can move, or remove it, as needed.
            this.tipoMaterialTableAdapter.Fill(this.tipoMaterialDataSet.TipoMaterial);

        }

        private void buttonIngresar_Click(object sender, EventArgs e) {
            MaterialDTO material = new MaterialDTO();
            int tmId = Convert.ToInt32(comboBoxTipoMaterial.SelectedValue.ToString().Trim()),
                iId = Convert.ToInt32(comboBoxIdioma.SelectedValue.ToString().Trim()),
                tId = Convert.ToInt32(comboBoxTematica.SelectedValue.ToString().Trim());
            TipoMaterialDTO tm = DAO.TmDAO.BuscarPorId(tmId);

        }
    }
}
