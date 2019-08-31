using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financias
{
    public partial class frmCorroborarContra : Form
    {
        public frmCorroborarContra()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComprobarFecha f = new ComprobarFecha();
            f.Desencriptar(Application.StartupPath + @"\Config\IO.dat");
            Form1 fo = new Form1();
            if (File.ReadAllText(Application.StartupPath + @"\Config\IO.dat") == txtcontra.Text)
            {
                frmEmpleados em = new frmEmpleados();
                em.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show("La contraseña ha sido incorrecta");
            }
            f.Encriptar(Application.StartupPath + @"\Config\IO.dat");
        }
    }
}
