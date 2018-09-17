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
    public partial class UsuariosCRUD : Form {
        public UsuariosCRUD() {
            InitializeComponent();
        }

        private void UsuariosCRUD_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'loaniumDataSet.UsuarioCompleto' table. You can move, or remove it, as needed.
            this.usuarioCompletoTableAdapter.Fill(this.loaniumDataSet.UsuarioCompleto);
            // TODO: This line of code loads data into the 'usuarioDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDataSet.Usuario);

        }
    }
}
