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
    public partial class frmSuscripción : Form
    {
        public frmSuscripción()
        {
            InitializeComponent();
            Tiempo();
        }
        private void Hora()
        {
            Byte[] encry = Encoding.Unicode.GetBytes(DateTime.Now.ToString("dd/MM/yyyy"));
            string fecha = Convert.ToBase64String(encry);
            File.WriteAllText("Key2", fecha);
            ComprobarFecha c = new ComprobarFecha();
            c.Encriptar("Key2");
            Application.Exit();
        }

        private void Tiempo()
        {
            trFecha.Enabled = true;
            lblFechaGlobal.Text = DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ModoPrueba()
        {
            DateTime tiempo = DateTime.Now;

             string limite = tiempo.AddDays(60).ToString("dd/MM/yyyy");

            Byte[] ecrypt = Encoding.Unicode.GetBytes(limite);
            File.WriteAllText("Key", Convert.ToBase64String(ecrypt), Encoding.Unicode);
            ComprobarFecha c = new ComprobarFecha();
            c.Encriptar("Key");
            File.WriteAllText("Tiempo de Licencia.txt", 2.ToString() + " Meses");

            frmHora h = new frmHora();
            if (h.error == true)
            {
                h.error = false;
                Application.Exit();
            }
        }

        private void Licencia()
        {
            if (txtMes.Text == "" && txtAño.Text == "" && txtDias.Text == "")
            {
                MessageBox.Show("Limite no establecido", "Error");
                this.Close();
            }
            else
            {
                if (txtDias.Text == "")
                    txtDias.Text = "0";

                if (txtMes.Text == "")
                    txtMes.Text = "0";

                if (txtAño.Text == "")
                    txtAño.Text = "0";

                string limite = "";

                double dia = 0;
                int mes = 0, año = 0;

                dia = double.Parse(txtDias.Text);
                mes = int.Parse(txtMes.Text);
                año = int.Parse(txtAño.Text);

                if (mes > 0)
                    dia = (30 * mes) + dia;
                if (año > 0)
                    dia = (360 * año) + dia;

                DateTime tiempo = DateTime.Now;
                
                limite = tiempo.AddDays(dia).ToString("dd/MM/yyyy");

                Byte[] ecrypt = Encoding.Unicode.GetBytes(limite);
                File.WriteAllText("Key", Convert.ToBase64String(ecrypt), Encoding.Unicode);

                ComprobarFecha c = new ComprobarFecha();
                c.Encriptar("Key");

                File.WriteAllText("Tiempo de Licencia.txt", dia.ToString()+" Dias");

                frmHora h = new frmHora();
                if(h.error == true)
                {
                    h.error = false;
                    Application.Exit();
                }
            }
            
        }

        private void ModoAdmin()
        {
            string limite = "Administrador Modo";
            Byte[] ecrypt = Encoding.Unicode.GetBytes(limite);
            File.WriteAllText("Key",Convert.ToBase64String(ecrypt),Encoding.Unicode);
            ComprobarFecha c = new ComprobarFecha();
            c.Encriptar("Key");

            frmHora h = new frmHora();
            if (h.error == true)
            {
                h.error = false;
                Application.Exit();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Licencia();
            this.Close();
        }

        private void btnAdmAcc_Click(object sender, EventArgs e)
        {
            ModoAdmin();
            this.Close();
        }

        private void trFecha_Tick(object sender, EventArgs e)
        {
            Tiempo();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Hora();
        }

        private void btnModoPrueba_Click(object sender, EventArgs e)
        {
            ModoPrueba();
        }

    }
}
