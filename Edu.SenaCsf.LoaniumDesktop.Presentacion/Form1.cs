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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => SesionControlador.Iniciar();
    }
}
