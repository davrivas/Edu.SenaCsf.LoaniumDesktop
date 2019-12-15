using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.SenaCsf.LoaniumDesktop.Logica.UtilLogica;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            try {
                this.tipoDocumentoTableAdapter.FillBy(this.tablasDataSet.TipoDocumento);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            if (UtilLogica.UsuarioSesion != null) {
                tbENames.Text = UtilLogica.UsuarioSesion.Nombres;
                tbESNames.Text = UtilLogica.UsuarioSesion.Apellidos;
                tbEDoc.Text = UtilLogica.UsuarioSesion.Documento;
                dtpEDateBirth.Value = UtilLogica.UsuarioSesion.FechaNacimiento;
                tbEMail.Text = UtilLogica.UsuarioSesion.CorreoElectronico;
                tbETel.Text = UtilLogica.UsuarioSesion.Telefono;
                cbDocType.SelectedValue = UtilLogica.UsuarioSesion.TipoDocumento.Id;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.Parent = i_menuBackground;
                lbl.BackColor = Color.Transparent;
            }
        }
    }
}
