using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;
using Edu.SenaCsf.LoaniumDesktop.Logica.Sesion;
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
    public partial class Registro : Form {
        public Registro() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tipoDocumentoDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.tipoDocumentoDataSet.TipoDocumento);

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e) {
            UsuarioDAO uDAO = new UsuarioDAO();
            TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
            int tdId = Convert.ToInt32(comboBoxTipoDocumento.SelectedValue.ToString().Trim());
            TipoDocumentoDTO td = tdDAO.BuscarPorId(tdId);
            string fnString = dateTimePickerFechaNacimiento.Value.ToShortDateString().Trim();
            UsuarioDTO usuario = new UsuarioDTO {
                Nombres = textBoxNombre.Text.Trim(),
                Apellidos = textBoxApellido.Text.Trim(),
                Documento = textBoxDocumento.Text.Trim(),
                FechaNacimiento = Convert.ToDateTime(fnString),
                CorreoElectronico = textBoxCorreoElectronico.Text.Trim(),
                Clave = textBoxClave.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                TipoDocumento = td
            };

            uDAO.Registrarse(usuario);
        }
    }
}
