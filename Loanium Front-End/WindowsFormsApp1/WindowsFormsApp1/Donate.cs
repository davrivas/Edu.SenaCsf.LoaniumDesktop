using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Donate : UserControl
    {
        public Donate()
        {
            InitializeComponent();

        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha enviado la solicitud de donación; ¡Gracias por tu colaboración!");
        }

        private void Donate_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.Parent = i_menuBackground;
                lbl.BackColor = Color.Transparent;
            }
        }

        private void lbl_materialType_Click(object sender, EventArgs e)
        {

        }
    }
}
