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
    public partial class frmContraseña : Form
    {
        public frmContraseña()
        {
            InitializeComponent();
            LoadGest();
            VerBton();
        }

        private void VerBton()
        {
            if (File.Exists(Application.StartupPath + @"\Config\IO.dat"))
                btnBorrar.Visible = true;
            else
                btnBorrar.Visible = false;
        }

        private void LoadGest()
        {
            if(File.Exists(Application.StartupPath+@"\Config\IO.dat"))
            {
                txtAnti.Visible = true;
                lblInfoAnti.Visible = true;
                lblAntiguaContra.Visible = true;
                txtAnti.Focus();
            }
            else
            {
                txtAnti.Visible = false;
                lblInfoAnti.Visible = false;
                lblAntiguaContra.Visible = false;
                txtNue.Focus();
            }
        }

        private void Aceptar()
        {
            if (txtNue.TextLength >= 6 && txtNue.TextLength <= 16)
            {
                lblNueva.ForeColor = Color.Black;

                if (File.Exists(Application.StartupPath + @"\Config\IO.dat"))
                {
                    ComprobarFecha c = new ComprobarFecha();
                    c.Desencriptar(Application.StartupPath + @"\Config\IO.dat");
                    string contra = File.ReadAllText(Application.StartupPath + @"\Config\IO.dat");
                    if (txtAnti.Text == contra)
                    {
                        if (txtConfirm.Text == txtNue.Text)
                        {
                            File.WriteAllText(Application.StartupPath + @"\Config\IO.dat", txtNue.Text);
                            lblInfoNue.ForeColor = Color.Green;
                            lblInfoConf.ForeColor = Color.Green;
                            lblInfo.ForeColor = Color.Green;
                            lblInfo.Text = "Se ha modificado la contraseña";
                            lblInfoNue.Text = "Coinciden";
                            lblInfoConf.Text = "Coiciden";
                            btnAcept.Text = "Cerrar";
                        }
                        else
                        {
                            lblInfoNue.ForeColor = Color.Red;
                            lblInfoConf.ForeColor = Color.Red;
                            lblInfoNue.Text = "No coinciden";
                            lblInfoConf.Text = "No coinciden";
                        }
                    }
                    else
                    {
                        lblInfoAnti.ForeColor = Color.Red;
                        lblInfoAnti.Text = "La contraseña no coincide";
                        if (txtNue.Text != txtConfirm.Text)
                        {
                            lblInfoNue.ForeColor = Color.Red;
                            lblInfoConf.ForeColor = Color.Red;
                            lblInfoNue.Text = "No coinciden";
                            lblInfoConf.Text = "No coinciden";
                        }

                    }
                    c.Encriptar(Application.StartupPath + @"\Config\IO.dat");
                }
                else
                {
                    if (txtConfirm.Text == txtNue.Text)
                    {
                        ComprobarFecha c = new ComprobarFecha();
                        File.WriteAllText(Application.StartupPath + @"\Config\IO.dat", txtNue.Text);
                        c.Encriptar(Application.StartupPath + @"\Config\IO.dat");
                        lblInfoNue.ForeColor = Color.Green;
                        lblInfoConf.ForeColor = Color.Green;
                        lblInfo.ForeColor = Color.Green;
                        lblInfo.Text = "Se ha creado la contraseña";
                        lblInfoNue.Text = "Coinciden";
                        lblInfoConf.Text = "Coiciden";
                        btnAcept.Text = "Cerrar";
                    }
                    else
                    {
                        lblInfoNue.ForeColor = Color.Red;
                        lblInfoConf.ForeColor = Color.Red;
                        lblInfoNue.Text = "No coinciden";
                        lblInfoConf.Text = "No coinciden";
                    }
                }
            }
            else
                lblNueva.ForeColor = Color.Red;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            switch (btnAcept.Text)
            {
                case "Aceptar":
                    Aceptar();
                    break;
                case "Cerrar":
                    Close();
                    break;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + @"\Config\IO.dat");
            MessageBox.Show("Se va a reiniciar la applicación");
            Application.Restart();
        }
    }
}
