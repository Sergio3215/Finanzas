using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    public partial class frmHora : Form
    {
        public bool error = false;
        public frmHora()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniSes_Click(object sender, EventArgs e)
        {
            frmInicioAdmin ad = new frmInicioAdmin();
            ad.Visible = true;
            this.Visible = false;
            error = true;
        }
    }
}
