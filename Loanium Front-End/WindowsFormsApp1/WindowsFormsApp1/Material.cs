using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Edu.SenaCsf.LoaniumDesktop.Datos.DTO;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Material : UserControl

    {
        private MaterialDTO materialSeleccionado = null;

        public Material()
        {
            InitializeComponent();
            try {
                this.tipoMaterialTableAdapter.Fill(this.tablasDataSet.TipoMaterial);
                this.idiomaTableAdapter.Fill(this.tablasDataSet.Idioma);
                this.tematicaTableAdapter.Fill(this.tablasDataSet.Tematica);
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbMaterial_SelectedValueChanged(object sender, EventArgs e) {
            lblISBN.Hide();
            tbISBN.Hide();
            tbISSN.Hide();
            lblISSN.Hide();
            tbEdit.Hide();
            lblEdit.Hide();
            tbLenght.Hide();
            lblLenght.Hide();
            switch (cbMaterial.SelectedValue) {
                case 1:
                    tbISBN.Show();
                    lblISBN.Show();
                    tbEdit.Show();
                    lblEdit.Show();
                    break;
                case 2:
                    tbISSN.Show();
                    lblISSN.Show();
                    break;
                case 3:
                case 4:
                    tbLenght.Show();
                    lblLenght.Show();
                    break;
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e) {
            if (btnMaterial.Text.Equals("Agregar material")) {
                MaterialDTO material = new MaterialDTO {
                    Titulo = tbTitle.Text.Trim(),
                    Autor = tbAuthor.Text.Trim(),
                    FechaPublicacion = dtpDateP.Value,
                    Descripcion = tbDesc.Text.Trim(),
                    Idioma = DAO.IDAO.BuscarPorId(Convert.ToInt32(cbLang.SelectedValue.ToString().Trim())),
                    TipoMaterial = DAO.TmDAO.BuscarPorId(Convert.ToInt32(cbMaterial.SelectedValue.ToString().Trim())),
                    Tematica = DAO.TDAO.BuscarPorId(Convert.ToInt32(cbThematic.SelectedValue.ToString().Trim()))
                };

                switch (cbMaterial.SelectedValue) {
                    case 1:
                        material.Isbn = tbISBN.Text.Trim();
                        material.Editorial = tbEdit.Text.Trim();
                        break;
                    case 2:
                        material.Issn = tbISSN.Text.Trim();
                        break;
                    case 3:
                    case 4:
                        material.Duracion = tbLenght.Text.Trim();
                        break;
                }
                DAO.MDAO.Ingresar(material);
            } else if (btnMaterial.Text.Equals("Editar Material")) {
                MaterialDTO material = materialSeleccionado;
                DAO.MDAO.Editar(material);
                materialSeleccionado = null;
            } else if (btnMaterial.Text.Equals("Eliminar Material")) {
                MaterialDTO material = materialSeleccionado;
                DAO.MDAO.Eliminar(material);
                materialSeleccionado = null;
            }
            
            tbTitle.Text = "";
            tbAuthor.Text = "";
            dtpDateP.Value = DateTime.Now;
            tbDesc.Text = "";
            cbLang.SelectedValue = 1;
            cbMaterial.SelectedValue = 1;
            cbThematic.SelectedValue = 1;
            tbISBN.Text = "";
            tbEdit.Text = "";
            tbISSN.Text = "";
            tbLenght.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (tbId.Text != "") {
                materialSeleccionado = DAO.MDAO.BuscarPorId(Convert.ToInt32(tbId.Text.Trim()));
                

                if (materialSeleccionado != null) {
                    tbTitle.Text = materialSeleccionado.Titulo;
                    tbAuthor.Text = materialSeleccionado.Autor;
                    dtpDateP.Value = materialSeleccionado.FechaPublicacion;
                    tbDesc.Text = materialSeleccionado.Descripcion;
                    cbLang.SelectedValue = materialSeleccionado.Idioma.Id;
                    cbMaterial.SelectedValue = materialSeleccionado.TipoMaterial.Id;
                    cbThematic.SelectedValue = materialSeleccionado.Tematica.Id;
                    tbISBN.Text = materialSeleccionado.Isbn;
                    tbISSN.Text = materialSeleccionado.Issn;
                    tbEdit.Text = materialSeleccionado.Editorial;
                    tbLenght.Text = materialSeleccionado.Duracion;
                }

                MostrarTodos();
                ActivarTodos();
            }
        }

        public void MostrarTodos() {
            lblAuthor.Show();
            lblDateP.Show();
            lblDescription.Show();
            lblMaterialType.Show();
            lblThematic.Show();
            lblTitle.Show();
            lblLang.Show();
            tbAuthor.Show();
            dtpDateP.Show();
            tbDesc.Show();
            cbMaterial.Show();
            cbThematic.Show();
            tbTitle.Show();
            cbLang.Show();
        }

        public void OcultarTodos() {
            lblAuthor.Hide();
            lblDateP.Hide();
            lblDescription.Hide();
            lblMaterialType.Hide();
            lblLang.Hide();
            lblThematic.Hide();
            lblTitle.Hide();
            tbAuthor.Hide();
            dtpDateP.Hide();
            tbDesc.Hide();
            cbMaterial.Hide();
            cbThematic.Hide();
            tbTitle.Hide();
            cbLang.Hide();
            lblISBN.Hide();
            tbISBN.Hide();
            tbISSN.Hide();
            lblISSN.Hide();
            tbEdit.Hide();
            lblEdit.Hide();
            tbLenght.Hide();
            lblLenght.Hide();
        }

        public void ActivarTodos() {
            tbAuthor.Enabled = true;
            dtpDateP.Enabled = true;
            tbDesc.Enabled = true;
            cbMaterial.Enabled = true;
            cbThematic.Enabled = true;
            tbTitle.Enabled = true;
            cbLang.Enabled = true;
            tbISBN.Enabled = true;
            tbEdit.Enabled = true;
            tbISSN.Enabled = true;
            tbLenght.Enabled = true;
        }

        public void DesactivarTodos() {
            tbAuthor.Enabled = false;
            dtpDateP.Enabled = false;
            tbDesc.Enabled = false;
            cbMaterial.Enabled = false;
            cbThematic.Enabled = false;
            tbTitle.Enabled = false;
            cbLang.Enabled = false;
            tbISBN.Enabled = false;
            tbEdit.Enabled = false;
            tbISSN.Enabled = false;
            tbLenght.Enabled = false;
        }
    }
}
