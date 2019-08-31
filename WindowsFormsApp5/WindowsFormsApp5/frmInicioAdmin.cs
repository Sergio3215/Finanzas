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
    public partial class frmInicioAdmin : Form
    {
        public frmInicioAdmin()
        {
            InitializeComponent();
        }

        private void Aceptar()
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "La Luna es toda MIA 654***")
            {
                frmSuscripción s = new frmSuscripción();
                s.Visible = true;
                this.Close();
            }
            else
                MessageBox.Show("Los datos proporcionados son invalidos, por favor comunicarse con el administrador","alerta");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
    }
}
