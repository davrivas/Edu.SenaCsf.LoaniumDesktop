using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.SenaCsf.LoaniumDesktop.Logica.DAO;

namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
            //Revisar bien eso después
            rtbUsuarios.Text = DAO.UDAO.Contar().ToString().Trim();
            rtbLibros.Text = DAO.MDAO.ContarLibros().ToString().Trim();
            rtbRevistas.Text = DAO.MDAO.ContarDiscos().ToString().Trim();
            rtbDiscos.Text = DAO.MDAO.ContarDiscos().ToString().Trim();
        }

        private void MyProfile_Load(object sender, EventArgs e)
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
