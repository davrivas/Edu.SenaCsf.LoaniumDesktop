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

        private void buttonIngresar_Click(object sender, EventArgs e) {
            MaterialDTO material = new MaterialDTO {
                Titulo = textBoxTitulo.Text.Trim(),
                Autor = textBoxAutor.Text.Trim(),
                FechaPublicacion = Convert.ToDateTime(fechaPublicacion.Value.ToShortDateString().Trim()),
                Descripcion = textBoxDescripcion.Text.Trim(),
                Idioma = DAO.IDAO.BuscarPorId(Convert.ToInt32(comboBoxIdioma.SelectedValue.ToString().Trim())),
                Tematica = DAO.TDAO.BuscarPorId(Convert.ToInt32(comboBoxTematica.SelectedValue.ToString().Trim())),
                TipoMaterial = DAO.TmDAO.BuscarPorId(Convert.ToInt32(comboBoxTipoMaterial.SelectedValue.ToString().Trim())),
                Isbn = "NULL", Editorial = "NULL", Issn = "NULL", Duracion = "NULL"
            };

            switch (material.TipoMaterial.Id) {
                case 1:
                    material.Isbn = textBoxIsbn.Text.Trim();
                    material.Editorial = textBoxEditorial.Text.Trim();
                    break;
                case 2:
                    material.Issn = textBoxIsbn.Text.Trim();
                    break;
                case 3:
                case 4:
                    material.Duracion = textBoxDuracion.Text.Trim();
                    break;
            }

            DAO.MDAO.Ingresar(material);
        }

        private void NuevoMaterial_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tipoMaterialDataSet.TipoMaterial' table. You can move, or remove it, as needed.
            this.tipoMaterialTableAdapter.Fill(this.tipoMaterialDataSet.TipoMaterial);
            // TODO: This line of code loads data into the 'tematicaSet.Tematica' table. You can move, or remove it, as needed.
            this.tematicaTableAdapter.Fill(this.tematicaSet.Tematica);
            // TODO: This line of code loads data into the 'idiomaDataSet.Idioma' table. You can move, or remove it, as needed.
            this.idiomaTableAdapter.Fill(this.idiomaDataSet.Idioma);

        }
    }
}
