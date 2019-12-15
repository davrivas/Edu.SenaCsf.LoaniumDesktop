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
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            List<Label> lbls = this.Controls.OfType<Label>().ToList();
            foreach (var lbl in lbls)
            {
                lbl.Parent = iMBTest;
                lbl.BackColor = Color.Transparent;
            }
        }
    }
}
