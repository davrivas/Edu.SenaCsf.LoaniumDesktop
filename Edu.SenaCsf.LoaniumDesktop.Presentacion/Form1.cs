using Edu.SenaCsf.LoaniumDesktop.Datos;
using Edu.SenaCsf.LoaniumDesktop.Logica;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'loaniumDataSet3.TipoMaterial' table. You can move, or remove it, as needed.
            this.tipoMaterialTableAdapter.Fill(this.loaniumDataSet3.TipoMaterial);
            // TODO: This line of code loads data into the 'loaniumDataSet2.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.loaniumDataSet2.Material);
            // TODO: This line of code loads data into the 'loaniumDataSet1.Idioma' table. You can move, or remove it, as needed.
            this.idiomaTableAdapter.Fill(this.loaniumDataSet1.Idioma);
            // TODO: This line of code loads data into the 'loaniumDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.loaniumDataSet.TipoDocumento);

        }
        
        private void ButtonIniciar_Click(object sender, EventArgs e) {
            UsuarioDAO uDAO = new UsuarioDAO();
            TipoDocumentoDAO tdDAO = new TipoDocumentoDAO();
            int tdId = Convert.ToInt32(comboBoxTipoDocumento.SelectedValue);
            TipoDocumentoDTO tipoDocumento = tdDAO.BuscarPorId(tdId);
            string documento = textBoxDocumento.Text.Trim();
            string clave = textBoxClave.Text.Trim();
            int usuario = uDAO.IniciarSesion(tipoDocumento, documento, clave);

            switch (usuario) {
                case 1:
                    MessageBox.Show("Bienvenido " + Sesion.Usuario.Nombres + " " + Sesion.Usuario.Apellidos);
                    break;
                case 2:
                    MessageBox.Show("ERROR: Usuario suspendido");
                    break;
                case 0:
                    MessageBox.Show("ERROR: No se pudo iniciar sesión");
                    break;
            }
            //DiscoDAO dDAO = new DiscoDAO();
            //DiscoDTO disco = dDAO.BuscarPorId(1);

            //if (disco != null) {
            //    MessageBox.Show("titulo: " + disco.Titulo +
            //        "duración: " + disco.Duracion + "min");
            //} else {
            //    MessageBox.Show("No se encontró disco");
            //}
        }

        private void buttonIngresar_Click(object sender, EventArgs e) {
            DiscoDAO mDAO = new DiscoDAO();
            IdiomaDAO iDAO = new IdiomaDAO();
            TipoMaterialDAO tmDAO = new TipoMaterialDAO();
            int iId = Convert.ToInt32(comboBoxIdioma.SelectedValue),
                tmId = Convert.ToInt32(comboBoxTipoMaterial.SelectedValue);
            DiscoDTO material = new DiscoDTO {
                Titulo = textBoxTitulo.Text.Trim(),
                Autor = textBoxAutor.Text.Trim(),
                FechaPublicacion = dateTimePickerFecha.Value,
                Descripcion = textBoxDescripcion.Text.Trim(),
                Idioma = iDAO.BuscarPorId(iId),
                TipoMaterial = tmDAO.BuscarPorId(tmId),
                Ejemplares = new List<EjemplarMaterialDTO>(),
                Duracion = textBoxDuracion.Text.Trim()
            };
            
        }
    }
}
