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
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();
            try {
                this.tematicaTableAdapter.Fill(this.tablasDataSet.Tematica);
                this.tipoMaterialTableAdapter.Fill(this.tablasDataSet.TipoMaterial);
                this.libroTableAdapter.Fill(this.vistaDataSet.Libro);
                this.revistaTableAdapter.Fill(this.vistaDataSet.Revista);
                this.discosTableAdapter.Fill(this.vistaDataSet.Discos);
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            if (UtilLogica.UsuarioSesion != null) {
                if (UtilLogica.UsuarioSesion.TipoUsuario.Id == 1) {
                    btnSelectMaterial.Hide();
                } else {
                    btnMaterialAdd.Hide();
                    btnMaterialEdit.Hide();
                }
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.BackColor = Color.Transparent;
                lbl.Parent = i_menuBackground;
            }
        }

        private void btnSelectMaterial_Click(object sender, EventArgs e)
        {
            loan1.Show();
            loan1.BringToFront();
        }

        private void btnMaterialAdd_Click(object sender, EventArgs e)
        {
            material1.Show();
            material1.BringToFront();
            material1.btnMaterial.Text = "Nuevo Material";
            material1.lbl_Material.Text = "Agregar Material";
            material1.MostrarTodos();
            material1.ActivarTodos();
        }

        private void btnMaterialEdit_Click(object sender, EventArgs e)
        {
            material1.Show();
            material1.BringToFront();
            material1.btnMaterial.Text = "Editar Material";
            material1.lbl_Material.Text = "Editar Material";
            material1.lblId.Show();
            material1.tbId.Show();
            material1.btnMaterial.Show();
            material1.btnSearch.Show();
            material1.OcultarTodos();
        }

        

        private void btnMaterialDelete_Click(object sender, EventArgs e) {
            material1.DesactivarTodos();
            material1.Show();
            material1.BringToFront();
            material1.btnMaterial.Text = "Eliminar Material";
            material1.lbl_Material.Text = "Eliminar Material";
            material1.lblId.Show();
            material1.tbId.Show();
            material1.btnSearch.Show();
            material1.btnMaterial.Show();
            material1.OcultarTodos();
        }
    }
}
